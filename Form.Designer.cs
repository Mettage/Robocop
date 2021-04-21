
namespace Robocopy {
partial class window
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
        if ( disposing && ( components != null ) )
        {
            components.Dispose();
        }
        base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( window ) );
        this.sourceLabel = new System.Windows.Forms.Label();
        this.destinationLabel = new System.Windows.Forms.Label();
        this.sourceTextBox = new System.Windows.Forms.TextBox();
        this.sourceBrowseButton = new System.Windows.Forms.Button();
        this.destinationBrowseButton = new System.Windows.Forms.Button();
        this.destinationTextBox = new System.Windows.Forms.TextBox();
        this.doitButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // sourceLabel
        //
        this.sourceLabel.AutoSize = true;
        this.sourceLabel.Location = new System.Drawing.Point( 12, 9 );
        this.sourceLabel.Name = "sourceLabel";
        this.sourceLabel.Size = new System.Drawing.Size( 44, 13 );
        this.sourceLabel.TabIndex = 0;
        this.sourceLabel.Text = "Source:";
        //
        // destinationLabel
        //
        this.destinationLabel.AutoSize = true;
        this.destinationLabel.Location = new System.Drawing.Point( 12, 48 );
        this.destinationLabel.Name = "destinationLabel";
        this.destinationLabel.Size = new System.Drawing.Size( 63, 13 );
        this.destinationLabel.TabIndex = 1;
        this.destinationLabel.Text = "Destination:";
        //
        // sourceTextBox
        //
        this.sourceTextBox.Location = new System.Drawing.Point( 12, 25 );
        this.sourceTextBox.Name = "sourceTextBox";
        this.sourceTextBox.Size = new System.Drawing.Size( 291, 20 );
        this.sourceTextBox.TabIndex = 2;
        this.sourceTextBox.TextChanged += new System.EventHandler( this.sourceTextBox_TextChanged );
        //
        // sourceBrowseButton
        //
        this.sourceBrowseButton.Location = new System.Drawing.Point( 309, 23 );
        this.sourceBrowseButton.Name = "sourceBrowseButton";
        this.sourceBrowseButton.Size = new System.Drawing.Size( 75, 23 );
        this.sourceBrowseButton.TabIndex = 3;
        this.sourceBrowseButton.Text = "Browse";
        this.sourceBrowseButton.UseVisualStyleBackColor = true;
        this.sourceBrowseButton.Click += new System.EventHandler( this.sourceBrowseButton_Click );
        //
        // destinationBrowseButton
        //
        this.destinationBrowseButton.Location = new System.Drawing.Point( 309, 62 );
        this.destinationBrowseButton.Name = "destinationBrowseButton";
        this.destinationBrowseButton.Size = new System.Drawing.Size( 75, 23 );
        this.destinationBrowseButton.TabIndex = 4;
        this.destinationBrowseButton.Text = "Browse";
        this.destinationBrowseButton.UseVisualStyleBackColor = true;
        this.destinationBrowseButton.Click += new System.EventHandler( this.destinationBrowseButton_Click );
        //
        // destinationTextBox
        //
        this.destinationTextBox.Location = new System.Drawing.Point( 12, 64 );
        this.destinationTextBox.Name = "destinationTextBox";
        this.destinationTextBox.Size = new System.Drawing.Size( 291, 20 );
        this.destinationTextBox.TabIndex = 5;
        this.destinationTextBox.TextChanged += new System.EventHandler( this.destinationTextBox_TextChanged );
        //
        // doitButton
        //
        this.doitButton.Location = new System.Drawing.Point( 390, 23 );
        this.doitButton.Name = "doitButton";
        this.doitButton.Size = new System.Drawing.Size( 70, 62 );
        this.doitButton.TabIndex = 6;
        this.doitButton.Text = "DO IT!";
        this.doitButton.UseVisualStyleBackColor = true;
        this.doitButton.Click += new System.EventHandler( this.doitButton_Click );
        //
        // window
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size( 479, 98 );
        this.Controls.Add( this.doitButton );
        this.Controls.Add( this.destinationTextBox );
        this.Controls.Add( this.destinationBrowseButton );
        this.Controls.Add( this.sourceBrowseButton );
        this.Controls.Add( this.sourceTextBox );
        this.Controls.Add( this.destinationLabel );
        this.Controls.Add( this.sourceLabel );
        this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
        this.Name = "window";
        this.Text = "ROBOCOP";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.window_FormClosing );
        this.ResumeLayout( false );
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label sourceLabel;
    private System.Windows.Forms.Label destinationLabel;
    private System.Windows.Forms.TextBox sourceTextBox;
    private System.Windows.Forms.Button sourceBrowseButton;
    private System.Windows.Forms.Button destinationBrowseButton;
    private System.Windows.Forms.TextBox destinationTextBox;
    private System.Windows.Forms.Button doitButton;
}
}

