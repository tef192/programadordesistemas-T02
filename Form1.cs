using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        // Variáveis para controle da largura
        private bool isCollapsed = false;
        private const int ExpandedWidth = 220;
        private const int CollapsedWidth = 60;

        public Form1()
        {
            InitializeComponent();
            ConfigurarDesign();
        }

        private void ConfigurarDesign()
        {
            // Força a janela a abrir em tela cheia
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Sistema de Gestão - Dashboard";

            // Configuração básica do Painel Lateral
            panelPrincipal.Width = ExpandedWidth;
            panelPrincipal.BackColor = Color.FromArgb(45, 45, 48); // Cinza escuro profissional
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Lógica simples de expansão/contração
            if (isCollapsed)
            {
                panelPrincipal.Width = ExpandedWidth;
                btnHome.Text = "  MENU";
                isCollapsed = false;
            }
            else
            { 
                .Width = CollapsedWidth;
                btnHome.Text = "  ☰";
                isCollapsed = true;
            }
        }
    }



