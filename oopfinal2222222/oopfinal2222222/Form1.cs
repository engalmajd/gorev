namespace oopfinal2222222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class personel
        {
            public string adi;
            public string soy;
            public string baslangic;
            public string bitis;
            public string maas;
            public string cinsiyet;
            public string pozisyon;
        }

        public class proje
        {
            public string proAdi;
            public string proNo;
            public string baslangic;
            public string bitis;
            public string konu;
            public string acik;
            public List<string> personalAd;
            public string durum;
        }
        public class gorev
        {
            public string gorAdi;
            public string gorno;
            public string bas;
            public string biti;
            public string projeAd;
            public string perAd;
            public string konu;
            public string durum;
            public string acik;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] vs = { "erkek", "kadin" };
            comboBox1.Items.AddRange(vs);
            string[] q = { "mudur", "memur" };
            comboBox2.Items.AddRange(q);
            string[] q2 = { "bas", "bit" };
            comboBox3.Items.AddRange(q2);
            string[] q3 = { "bas", "bit" };
            comboBox6.Items.AddRange(q3);
        }

        List<personel> listper = new List<personel>();
        private void button1_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.adi = textBox1.Text;
            personel.soy = textBox2.Text;
            personel.baslangic = textBox3.Text;
            personel.bitis = textBox4.Text;
            personel.maas = textBox5.Text;
            personel.cinsiyet = comboBox1.SelectedItem.ToString();
            personel.pozisyon = comboBox2.SelectedItem.ToString();

            listper.Add(personel);

            comboBox4.Items.Add(textBox1.Text);

            List<string> vs = new List<string>();

            foreach (var item in listper)
            {
                vs.Add(item.baslangic);
                vs.Add(item.bitis);
                vs.Add(item.adi);
                vs.Add(item.soy);
                vs.Add(item.cinsiyet);
            }
            //foreach (Control item in tabPage1.Controls)
            //{
            //    if (item is TextBox || item is ComboBox)
            //    {
            //        item.Text = "";
            //    }
            //}
            ListViewItem itm = new ListViewItem(vs.ToArray());
            listView1.Items.Add(itm);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0)
            {
                listBox1.Items.Add(comboBox4.SelectedItem);
            }
        }
        List<proje> listpro = new List<proje>();
        private void button3_Click(object sender, EventArgs e)
        {
            proje proje = new proje();
            proje.proAdi = textBox10.Text;
            proje.proNo = textBox9.Text;
            proje.baslangic = textBox8.Text;
            proje.bitis = textBox7.Text;
            proje.konu = textBox6.Text;
            proje.acik = textBox11.Text;
            proje.durum = comboBox3.SelectedItem.ToString();
            proje.personalAd = new List<string>();
            foreach (var item in listBox1.Items)
            {
                proje.personalAd.Add(item.ToString());
            }
            listpro.Add(proje);
            comboBox5.Items.Add(textBox10.Text);

            

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex >= 0)
            {

                comboBox8.Items.Clear();
                foreach (var item in listpro)
                {
                    if (comboBox5.SelectedItem.ToString() == item.proAdi)
                    {
                        comboBox8.Items.AddRange(item.personalAd.ToArray());
                    }
                }
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gorev gorev = new gorev();
            gorev.gorAdi = textBox17.Text;
            gorev.gorno = textBox16.Text;
            gorev.bas = textBox15.Text;
            gorev.biti = textBox14.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBox7.Text;
                listView1.SelectedItems[0].SubItems[4].Text = textBox6.Text;
                listView1.SelectedItems[0].SubItems[5].Text = comboBox1.Text;
                listView1.SelectedItems[0].SubItems[6].Text = textBox4.Text;
                listView1.SelectedItems[0].SubItems[7].Text = textBox5.Text;

            }
            foreach (Control item in tabPage1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox7.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox6.Text = listView1.SelectedItems[0].SubItems[4].Text;
               
                //textBox4.Text = listView1.SelectedItems[0].SubItems[6].Text;
                //textBox5.Text = listView1.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}