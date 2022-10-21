using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.IO;
using VideoLibrary;
using System.Windows.Forms;
using MediaToolkit.Model;
using MediaToolkit;
using System.Threading.Tasks;
using Clipboard = System.Windows.Clipboard;
using System.Security.Policy;

namespace mp3_converter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //delegate
        private delegate void del_setText(Control control, string text);

        //tempo trascorso
        bool runThread;
        Thread timeElapseThread;
        short secondElapse, minuteElapse;

        short downloaded = 0;

        bool tutorial = true;

        //eventi bottoni
        private async void btnDownload_Click(object sender, EventArgs e) {
            if (tDirectory.Text == string.Empty) {
                _messageBox("Selezionare una directory!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (tUrl.Text == string.Empty) {
                _messageBox("Campo URL vuoto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                try {
                    downloadReset();
                    runThread = true;
                    tUrl.ReadOnly = true;
                    pbProgress.Visible = true;
                    btnDownload.Visible = false;
                    btnSetDirectory.Enabled = false;
                    timeElapseThread = new Thread(timeElapseThread_func);
                    timeElapseThread.Start();
                    await Task.Run(() => downloadAudio());
                    tUrl.ReadOnly = false;
                    pbProgress.Visible = false;
                    btnDownload.Visible = true;
                    btnSetDirectory.Enabled = true;
                    lblCountSong.Text = "Download completato!";
                } catch (Exception ex) {
                    downloadReset();
                    _messageBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnHelp_Click(object sender, EventArgs e) {
            MessageBox.Show("Per scaricare una canzone inserire un url di YouTube e cliccare 'Scarica'.\n" +
                "Per scaricare più canzoni inserire un url, andare a capo e così via", "YouTube MP3 Converter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSetDirectory_Click(object sender, EventArgs e) {
            FolderBrowserDialog opFile = new FolderBrowserDialog();
            if (opFile.ShowDialog().Equals(DialogResult.OK))
                tDirectory.Text = opFile.SelectedPath + @"\";
        }
        // ---

        //metodi
        private void _messageBox(string msg, MessageBoxButtons mbb, MessageBoxIcon mbi) {
            MessageBox.Show(msg, "YouTube MP3 Converter", mbb, mbi);
        }
        private void downloadReset() {
            downloaded = 0;
            secondElapse = 0;
            minuteElapse = 0;
        }
        private void downloadAudio() {
            var source = tDirectory.Text;
            var youtube = YouTube.Default;
            string[] url = tUrl.Text.Split('\n');
            setText(lblCountSong, $"File rimanenti: {url.Length - downloaded}");

            try {
                while (downloaded <= url.Length - 1) { //finchè lo short downloaded è minore dell'array url (contiene tutti gli url inseriti), scarico/converto l'url
                    var video = youtube.GetVideo(url[downloaded]);
                    string videoName_noMP4 = $"{video.FullName}.mp3".Replace(".mp4", string.Empty);
                    setText(tUrl, tUrl.Text.Replace(url[downloaded], videoName_noMP4));
                    File.WriteAllBytes(source + video.FullName, video.GetBytes());

                    var inputFile = new MediaFile { Filename = (source + video.FullName) };
                    var outputFile = new MediaFile { Filename = $"{source + videoName_noMP4}" };
                    using (var engine = new Engine()) {
                        engine.GetMetadata(inputFile);
                        engine.Convert(inputFile, outputFile);
                    }
                    File.Delete(source + video.FullName); //elimino il file .mp4 utilizzato per la conversione
                    downloaded++;
                    setText(tUrl, tUrl.Text.Replace(videoName_noMP4, string.Empty));
                    setText(lblCountSong, $"File rimanenti: {url.Length - downloaded}");
                }
                runThread = false;
            } catch (Exception ex) {
                _messageBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void timeElapseThread_func() {
            while (runThread) { //Thread per tenere traccia del tempo passato
                secondElapse++;
                if (secondElapse > 59) { //se i secondi superano i 59, passo al minuto e così via
                    minuteElapse++;
                    secondElapse = 0;
                    setText(lblTimeElapse, $"Tempo trascorso: {minuteElapse}:{secondElapse}m");
                } else
                    setText(lblTimeElapse, $"Tempo trascorso: {minuteElapse}:{secondElapse}m");
                Thread.Sleep(1000);
            }
        }

        private void tUrl_Click(object sender, EventArgs e) {
            if (tutorial) {
                tutorial = false;
                tUrl.Text = string.Empty;
            }
        }

        // ---

        //metodi delegate
        private void setText(Control control, string text) { //delegate per modificare text di componenti da Thread
            if (control.InvokeRequired)
                control.Invoke(new del_setText(setText), new object[] { control, text });
            else
                control.Text = text;
        }
    }
}