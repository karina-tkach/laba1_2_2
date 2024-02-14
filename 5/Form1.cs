namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;

            transparencyButton.Click += new EventHandler(btnActions_Click);
            colorButton.Click += new EventHandler(btnActions_Click);
            helloWorldButton.Click += new EventHandler(btnActions_Click);
            supermegabutton.Click += new EventHandler(btnActions_Click);
        }
        delegate void ButtonClickHandler(object sender, EventArgs e);

        //click separagtely and only for megabutton
        private void btnActions_Click(object sender, EventArgs e)
        {
            if (sender == transparencyButton)
            {
                SetTransparency();
            }
            else if (sender == colorButton)
            {
                SetBackgroundColor();
            }
            else if (sender == helloWorldButton)
            {
                DisplayMessage();
            }
            else if(sender == supermegabutton)
            {
                CheckBoxes(e);
            }
        }

        private void SetTransparency()
        {
            if (this.Opacity == 1)
            {
                this.Opacity = 0.5;
            }
            else
            {
                this.Opacity = 1;
            }
        }

        private void SetBackgroundColor()
        {
            if (this.BackColor == Color.LightGray)
            {
                this.BackColor = Color.LightBlue;
            }
            else
            {
                this.BackColor = Color.LightGray;
            }
        }

        private void DisplayMessage()
        {
            MessageBox.Show("Hello World!");
        }

        private void CheckBoxes(EventArgs e)
        {
            if (consumesTransparency_checkBox.Checked)
                btnActions_Click(transparencyButton, e);

            if (consumesColor_checkBox.Checked)
                btnActions_Click(colorButton, e);

            if (consumesHelloWorld_checkBox.Checked)
                btnActions_Click(helloWorldButton, e);
        }

        private void supermegabutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }
    }
}
