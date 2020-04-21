using System.Drawing;
using System.Windows.Forms;

namespace Lab9_Parallelism
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        Label timeLabel;
        Label hideLabel;
        Label cntLabel;
        TextBox timeTB;
        TextBox cntTB;
        CheckBox hide;
        public Label area;
        private void InitializeComponent()
        {
            timeLabel = new Label();
            hideLabel = new Label();
            cntLabel = new Label();
            timeTB = new TextBox();
            cntTB = new TextBox();
            hide = new CheckBox();
            area = new Label();

            area.AutoSize = false;
            area.Size = new Size(740, 660);
            area.Location = new Point(240, 20);
            area.BackColor = Color.White;

            timeLabel.Text = "Среднее время жизни окружности: ";
            timeLabel.Size = new Size(150, 40);
            timeLabel.AutoSize = false;
            timeLabel.Location = new Point(10, 10);

            timeTB.Text = "3";
            timeTB.Location = new Point(160, 20);
            timeTB.Size = new Size(50, 20);
            timeTB.TabStop = false;

            cntLabel.Text = "Количество окружностей:";
            cntLabel.Size = new Size(150, 40);
            cntLabel.AutoSize = false;
            cntLabel.Location = new Point(10, 60);

            cntTB.Text = "5";
            cntTB.Location = new Point(160, 70);
            cntTB.Size = new Size(50, 20);
            cntTB.TabStop = false;

            hideLabel.Text = "Начать показ";
            hideLabel.Location = new Point(10, 110);
            hideLabel.Size = new Size(155, 40);
            hideLabel.AutoSize = false;

            hide.Location = new Point(170, 110);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Text = "AppForm";
            this.Controls.Add(area);
            this.Controls.Add(timeLabel);
            this.Controls.Add(timeTB);
            this.Controls.Add(cntLabel);
            this.Controls.Add(cntTB);
            this.Controls.Add(hide);
            this.Controls.Add(hideLabel);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }


        #endregion
    }
}