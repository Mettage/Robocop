using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Robocopy {
public partial class window : Form
{
    static string currentDir = Environment.CurrentDirectory;
    static string settings = currentDir + "\\settings.ini";
    static string robocopB = currentDir + "\\robocop.bat";
    static string sourceD = "";
    static string destinationD = "";
    public window()
    {
        Remove();
        Inicialize();
        InitializeComponent();
        doitButton.Enabled = false;
        sourceTextBox.Text = sourceD;
        destinationTextBox.Text = destinationD;
    }

    void Remove()
    {
        if ( File.Exists( robocopB ) )
        {
            File.Delete( robocopB );
        }
    }

    void Inicialize()
    {
        if ( File.Exists( settings ) )
        {
            StreamReader sett = new StreamReader( settings );
            int lineNumber = 0;
            string line = sett.ReadLine();
            while ( line != null )
            {
                lineNumber++;
                line = sett.ReadLine();
                if ( lineNumber == 1 ) { sourceD = line; }
                if ( lineNumber == 2 ) { destinationD = line; }
            }
            sett.Close();
        }
        else
        {
            using ( FileStream fileS = new FileStream( settings, FileMode.Create ) ) { }
            Set();
        }
    }

    void Set()
    {
        StreamWriter settings = new StreamWriter( "settings.ini" );
        settings.WriteLine( "*** ROBOCOY settings ***" );
        settings.WriteLine( sourceD );
        settings.WriteLine( destinationD );
        settings.Close();
    }

    void ButEna()
    {
        if ( Directory.Exists( sourceD ) && Directory.Exists( destinationD ) )
        {
            doitButton.Enabled = true;
        }
        else
        {
            doitButton.Enabled = false;
        }
    }

    private async void Doit()
    {
        Task<int> doitc = null;
        doitc = Roboco();
        doitButton.Enabled = false;
        await doitc;
        doitButton.Enabled = true;
    }

    private Task<int> Roboco()
    {
        using ( StreamWriter command = new StreamWriter( robocopB ) )
        {
            command.WriteLine( $"@echo off" );
            command.WriteLine( $"robocopy \"" + sourceD + "\" \"" + destinationD + "\"" );
            command.Close();
        }
        return RunProcessAsync( robocopB );
    }

    private Task<int> RunProcessAsync( string fileName )
    {
        var tcs = new TaskCompletionSource<int>();
        var process = new Process
        {
            StartInfo = { FileName = fileName },
            EnableRaisingEvents = true
        };
        process.Exited += ( sender, args ) =>
        {
            tcs.SetResult( process.ExitCode );
            process.Dispose();
        };

        process.Start();
        return tcs.Task;
    }

    private void sourceTextBox_TextChanged( object sender, EventArgs e )
    {
        sourceD = sourceTextBox.Text;
        ButEna();
        if ( Directory.Exists( sourceD ) ) { Set(); ButEna(); }
    }

    private void sourceBrowseButton_Click( object sender, EventArgs e )
    {
        FolderBrowserDialog sourceF = new FolderBrowserDialog();
        sourceF.SelectedPath = sourceD;
        sourceF.Description = "Choose Source folder";
        if ( sourceF.ShowDialog() == DialogResult.OK )
        {
            sourceTextBox.Text = sourceF.SelectedPath;
            sourceD = sourceF.SelectedPath;
            Set();
        }
    }

    private void destinationTextBox_TextChanged( object sender, EventArgs e )
    {
        destinationD = destinationTextBox.Text;
        ButEna();
        if ( Directory.Exists( destinationD ) ) { Set(); }
    }

    private void destinationBrowseButton_Click( object sender, EventArgs e )
    {
        FolderBrowserDialog destinationF = new FolderBrowserDialog();
        destinationF.SelectedPath = destinationD;
        destinationF.Description = "Choose Destination folder";
        if ( destinationF.ShowDialog() == DialogResult.OK )
        {
            destinationTextBox.Text = destinationF.SelectedPath;
            destinationD = destinationF.SelectedPath;
            Set();
        }
    }

    private void doitButton_Click( object sender, EventArgs e )
    {
        Doit();
    }

    private void window_FormClosing( object sender, FormClosingEventArgs e )
    {
        Remove();
    }
}
}
