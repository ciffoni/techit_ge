using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            //instanciando um novo objeto
            FrmAluno aluno = new FrmAluno();
            //abrir a tela do aluno
            aluno.ShowDialog();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            FrmProfessor prof= new FrmProfessor();
            prof.ShowDialog();
        }
    }
}
