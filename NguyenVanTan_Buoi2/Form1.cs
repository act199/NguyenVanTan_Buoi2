namespace NguyenVanTan_Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool KtraSNT(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void txt_n_TextChanged(object sender, EventArgs e)
        {
            string kq = string.Empty;
            if (txt_n.Text != string.Empty)
            {
                if (KtraSNT(int.Parse(txt_n.Text)))

                {
                    txt_kq.Text = "Là Số Nguyên Tố";
                }
                else
                {
                    txt_kq.Text = "Không Phải số nguyên Tố";
                }
                for (int i = 2; i < int.Parse(txt_n.Text); i++)
                {
                    if (KtraSNT(i))
                    {
                        kq += " " + i;
                    }
                }
                txt_SNTn.Text = kq;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

 
    
