namespace CellTrack.Views.UserControls
{
    partial class frmAdmin
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.tbConfigs = new MetroFramework.Controls.MetroTabControl();
            this.tbPageUsuarios = new MetroFramework.Controls.MetroTabPage();
            this.tbPagePerfilesRoles = new MetroFramework.Controls.MetroTabPage();
            this.tbPageGrupos = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.tbConfigs.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Configuraciones";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 441;
            this.lineShape1.Y1 = 35;
            this.lineShape1.Y2 = 35;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(982, 596);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // tbConfigs
            // 
            this.tbConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConfigs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbConfigs.Controls.Add(this.tbPageUsuarios);
            this.tbConfigs.Controls.Add(this.tbPagePerfilesRoles);
            this.tbConfigs.Controls.Add(this.tbPageGrupos);
            this.tbConfigs.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tbConfigs.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbConfigs.HotTrack = true;
            this.tbConfigs.ItemSize = new System.Drawing.Size(100, 43);
            this.tbConfigs.Location = new System.Drawing.Point(9, 40);
            this.tbConfigs.Name = "tbConfigs";
            this.tbConfigs.SelectedIndex = 0;
            this.tbConfigs.Size = new System.Drawing.Size(970, 553);
            this.tbConfigs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbConfigs.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbConfigs.TabIndex = 0;
            this.tbConfigs.UseSelectable = true;
            this.tbConfigs.UseStyleColors = true;
            // 
            // tbPageUsuarios
            // 
            this.tbPageUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.tbPageUsuarios.HorizontalScrollbarBarColor = true;
            this.tbPageUsuarios.HorizontalScrollbarHighlightOnWheel = false;
            this.tbPageUsuarios.HorizontalScrollbarSize = 10;
            this.tbPageUsuarios.Location = new System.Drawing.Point(4, 47);
            this.tbPageUsuarios.Name = "tbPageUsuarios";
            this.tbPageUsuarios.Size = new System.Drawing.Size(962, 502);
            this.tbPageUsuarios.TabIndex = 0;
            this.tbPageUsuarios.Text = "Usuarios";
            this.tbPageUsuarios.VerticalScrollbarBarColor = true;
            this.tbPageUsuarios.VerticalScrollbarHighlightOnWheel = false;
            this.tbPageUsuarios.VerticalScrollbarSize = 10;
            // 
            // tbPagePerfilesRoles
            // 
            this.tbPagePerfilesRoles.BackColor = System.Drawing.Color.Transparent;
            this.tbPagePerfilesRoles.HorizontalScrollbarBarColor = true;
            this.tbPagePerfilesRoles.HorizontalScrollbarHighlightOnWheel = false;
            this.tbPagePerfilesRoles.HorizontalScrollbarSize = 10;
            this.tbPagePerfilesRoles.Location = new System.Drawing.Point(4, 47);
            this.tbPagePerfilesRoles.Name = "tbPagePerfilesRoles";
            this.tbPagePerfilesRoles.Size = new System.Drawing.Size(962, 502);
            this.tbPagePerfilesRoles.TabIndex = 1;
            this.tbPagePerfilesRoles.Text = "Perfiles y Roles";
            this.tbPagePerfilesRoles.VerticalScrollbarBarColor = true;
            this.tbPagePerfilesRoles.VerticalScrollbarHighlightOnWheel = false;
            this.tbPagePerfilesRoles.VerticalScrollbarSize = 10;
            // 
            // tbPageGrupos
            // 
            this.tbPageGrupos.BackColor = System.Drawing.Color.Transparent;
            this.tbPageGrupos.HorizontalScrollbarBarColor = true;
            this.tbPageGrupos.HorizontalScrollbarHighlightOnWheel = false;
            this.tbPageGrupos.HorizontalScrollbarSize = 10;
            this.tbPageGrupos.Location = new System.Drawing.Point(4, 47);
            this.tbPageGrupos.Name = "tbPageGrupos";
            this.tbPageGrupos.Size = new System.Drawing.Size(962, 502);
            this.tbPageGrupos.TabIndex = 3;
            this.tbPageGrupos.Text = "Grupos";
            this.tbPageGrupos.VerticalScrollbarBarColor = true;
            this.tbPageGrupos.VerticalScrollbarHighlightOnWheel = false;
            this.tbPageGrupos.VerticalScrollbarSize = 10;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tbConfigs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(984, 598);
            this.Name = "frmAdmin";
            this.Size = new System.Drawing.Size(982, 596);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.tbConfigs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private MetroFramework.Controls.MetroTabControl tbConfigs;
        private MetroFramework.Controls.MetroTabPage tbPageUsuarios;
        private MetroFramework.Controls.MetroTabPage tbPagePerfilesRoles;
        private MetroFramework.Controls.MetroTabPage tbPageGrupos;
    }
}
