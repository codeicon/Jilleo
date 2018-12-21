

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Jilleo
{
  public partial class JilleoForm : Form
  {
    string videoFileName = "";
    string logFileName = "";
    StreamWriter logFileStream = null;
    DateTime startTime;
    DateTime pauseTime;

    public JilleoForm()
    {
      InitializeComponent();
    }

    private void openButton_Click(object sender, EventArgs e)
    {
      if (openVideoFileDialog.ShowDialog() == DialogResult.OK) {
        videoFileName = openVideoFileDialog.FileName;
        logFileName =
          Path.GetDirectoryName(videoFileName) + "\\" +
          Path.GetFileNameWithoutExtension(videoFileName) + "_jilleo.txt";
        OnStop();
        File.Delete(logFileName);
        videoPlayer.URL = videoFileName;
        videoPlayer.Ctlcontrols.stop();
      }
    }

    private void videoPlayer_PlayStateChange(
      object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
    {
      switch (e.newState) {
      case 1 :
        OnStop();
        break;
      case 2 :
        OnPause();
        break;
      case 3 :
        OnPlay();
        break;
      }
    }

    void OnStop()
    {
      if (logFileStream != null) {
        LogLine("Video Stopped");
        logFileStream.Close();
        logFileStream = null;
        saveLogFileDialog.FileName = Path.GetFileName(logFileName);
        if (saveLogFileDialog.ShowDialog() == DialogResult.OK)
          File.Move(logFileName, saveLogFileDialog.FileName);
      }
    }

    void OnPause()
    {
      pauseTime = DateTime.Now;
      LogLine("Video Paused");
    }

    void OnPlay()
    {
      if (logFileStream != null) {
        startTime += DateTime.Now - pauseTime;
        LogLine("Video Resumed");
      } else {
        startTime = DateTime.Now;
        logFileStream = File.AppendText(logFileName);
        LogLine("Video Started");
      }
      Activate();
      spaceButton.Focus();
    }

    void LogLine(string line)
    {
      if (logFileStream != null) {
        TimeSpan ts = DateTime.Now - startTime;
        DateTime dt = new DateTime(2000,1,1,0,0,0,0) + ts;
        logFileStream.WriteLine(dt.ToString("HH:mm:ss.fff") + ": " + line);
      }
    }

    private void JilleoForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      OnStop();
    }

    private void spaceButton_Click(object sender, EventArgs e)
    {
      LogLine("Space Bar Pressed");
    }

    private void spaceButton_MouseDown(object sender, MouseEventArgs e)
    {
      LogLine("Mouse Button Held");
    }

    private void spaceButton_MouseUp(object sender, MouseEventArgs e)
    {
      LogLine("Mouse Button Released");
    }
  }
}
