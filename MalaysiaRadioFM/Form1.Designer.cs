namespace MalaysiaRadioFM;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        listBoxStations = new ListBox();
        btnPlay = new Button();
        btnStop = new Button();
        trackBarVolume = new TrackBar();
        labelVolume = new Label();
        labelStatus = new Label();
        labelTitle = new Label();
        ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
        SuspendLayout();
        // 
        // listBoxStations
        // 
        listBoxStations.FormattingEnabled = true;
        listBoxStations.ItemHeight = 15;
        listBoxStations.Location = new Point(12, 50);
        listBoxStations.Name = "listBoxStations";
        listBoxStations.Size = new Size(360, 304);
        listBoxStations.TabIndex = 0;
        // 
        // btnPlay
        // 
        btnPlay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnPlay.Location = new Point(12, 360);
        btnPlay.Name = "btnPlay";
        btnPlay.Size = new Size(120, 40);
        btnPlay.TabIndex = 1;
        btnPlay.Text = "Play";
        btnPlay.UseVisualStyleBackColor = true;
        btnPlay.Click += BtnPlay_Click;
        // 
        // btnStop
        // 
        btnStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnStop.Location = new Point(138, 360);
        btnStop.Name = "btnStop";
        btnStop.Size = new Size(120, 40);
        btnStop.TabIndex = 2;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = true;
        btnStop.Click += BtnStop_Click;
        // 
        // trackBarVolume
        // 
        trackBarVolume.Location = new Point(12, 430);
        trackBarVolume.Maximum = 100;
        trackBarVolume.Name = "trackBarVolume";
        trackBarVolume.Size = new Size(360, 45);
        trackBarVolume.TabIndex = 3;
        trackBarVolume.Value = 50;
        trackBarVolume.Scroll += TrackBarVolume_Scroll;
        // 
        // labelVolume
        // 
        labelVolume.AutoSize = true;
        labelVolume.Location = new Point(12, 412);
        labelVolume.Name = "labelVolume";
        labelVolume.Size = new Size(80, 15);
        labelVolume.TabIndex = 4;
        labelVolume.Text = "Volume: 50%";
        // 
        // labelStatus
        // 
        labelStatus.AutoSize = true;
        labelStatus.Location = new Point(264, 373);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(108, 15);
        labelStatus.TabIndex = 5;
        labelStatus.Text = "Status: Not playing";
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        labelTitle.Location = new Point(12, 9);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(220, 30);
        labelTitle.TabIndex = 6;
        labelTitle.Text = "Malaysia Radio FM";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 491);
        Controls.Add(labelTitle);
        Controls.Add(labelStatus);
        Controls.Add(labelVolume);
        Controls.Add(trackBarVolume);
        Controls.Add(btnStop);
        Controls.Add(btnPlay);
        Controls.Add(listBoxStations);
        Name = "Form1";
        Text = "Malaysia Radio FM";
        FormClosing += Form1_FormClosing;
        ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox listBoxStations;
    private Button btnPlay;
    private Button btnStop;
    private TrackBar trackBarVolume;
    private Label labelVolume;
    private Label labelStatus;
    private Label labelTitle;
}
