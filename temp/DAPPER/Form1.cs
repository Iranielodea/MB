using DAPPER.Cross;
using DAPPER.Dominio;
using DAPPER.Dominio.Entidades;
using System;
using System.Windows.Forms;

namespace WindowsFormsTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RegisterMappings.Register();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var work = new UnitOfWork();
            var banco = work.BancoRepositorio.GetById(Convert.ToInt32(textBox1.Text));

            textBox2.Clear();
            if (banco != null)
                textBox2.Text = banco.Nome;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var work = new UnitOfWork();
            try
            {
                var banco = new Banco();

                banco = work.BancoRepositorio.GetById(Convert.ToInt32(textBox1.Text));
                banco.Nome = textBox2.Text;

                work.BeginTransaction();
                work.BancoRepositorio.Update(banco);

                //Convert.ToInt32("agdc");

                work.Commit();


                //var repo = new BancoRepositorio();
                //var banco = repo.GetById(Convert.ToInt32(textBox1.Text));
                //banco.Nome = textBox2.Text;

                //repo.Update(banco);

                //using (var trans = new TransactionScope())
                //{
                //    var repo = new BancoRepositorio();
                //    var banco = repo.GetById(Convert.ToInt32(textBox1.Text));
                //    banco.Nome = textBox2.Text;

                //    repo.Update(banco);
                //    trans.Complete();
                //}
                Listar();
            }
            catch (Exception ex)
            {
                work.RollBack();
                MessageBox.Show("erro: " + ex.Message);
            }
            finally
            {
                work.Dispose();
            }
        }

        private void Listar()
        {
            using (var work = new UnitOfWork())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = work.BancoRepositorio.GetAll();
            }
        }
    }
}
