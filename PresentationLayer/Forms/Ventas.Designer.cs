namespace FOOD
{
    partial class Ventas
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarVenta = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtFiltro = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbFiltro = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvVentas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pdRecibo = new System.Drawing.Printing.PrintDocument();
            this.ppdRecibo = new System.Windows.Forms.PrintPreviewDialog();
            this.saleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.AllowAnimations = true;
            this.btnAgregarVenta.AllowMouseEffects = true;
            this.btnAgregarVenta.AllowToggling = false;
            this.btnAgregarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarVenta.AnimationSpeed = 200;
            this.btnAgregarVenta.AutoGenerateColors = false;
            this.btnAgregarVenta.AutoRoundBorders = false;
            this.btnAgregarVenta.AutoSizeLeftIcon = true;
            this.btnAgregarVenta.AutoSizeRightIcon = true;
            this.btnAgregarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarVenta.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarVenta.BackgroundImage")));
            this.btnAgregarVenta.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarVenta.ButtonText = "Agregar venta";
            this.btnAgregarVenta.ButtonTextMarginLeft = 0;
            this.btnAgregarVenta.ColorContrastOnClick = 45;
            this.btnAgregarVenta.ColorContrastOnHover = 45;
            this.btnAgregarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAgregarVenta.CustomizableEdges = borderEdges1;
            this.btnAgregarVenta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarVenta.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarVenta.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarVenta.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarVenta.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarVenta.Font = new System.Drawing.Font("Poppins Medium", 11F);
            this.btnAgregarVenta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVenta.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarVenta.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarVenta.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarVenta.IconMarginLeft = 11;
            this.btnAgregarVenta.IconPadding = 8;
            this.btnAgregarVenta.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarVenta.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarVenta.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarVenta.IconSize = 1;
            this.btnAgregarVenta.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarVenta.IdleBorderRadius = 6;
            this.btnAgregarVenta.IdleBorderThickness = 1;
            this.btnAgregarVenta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarVenta.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarVenta.IdleIconLeftImage")));
            this.btnAgregarVenta.IdleIconRightImage = null;
            this.btnAgregarVenta.IndicateFocus = false;
            this.btnAgregarVenta.Location = new System.Drawing.Point(892, 197);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarVenta.OnDisabledState.BorderRadius = 6;
            this.btnAgregarVenta.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarVenta.OnDisabledState.BorderThickness = 1;
            this.btnAgregarVenta.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarVenta.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarVenta.OnDisabledState.IconLeftImage = null;
            this.btnAgregarVenta.OnDisabledState.IconRightImage = null;
            this.btnAgregarVenta.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarVenta.onHoverState.BorderRadius = 6;
            this.btnAgregarVenta.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarVenta.onHoverState.BorderThickness = 1;
            this.btnAgregarVenta.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarVenta.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVenta.onHoverState.IconLeftImage = null;
            this.btnAgregarVenta.onHoverState.IconRightImage = null;
            this.btnAgregarVenta.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarVenta.OnIdleState.BorderRadius = 6;
            this.btnAgregarVenta.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarVenta.OnIdleState.BorderThickness = 1;
            this.btnAgregarVenta.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarVenta.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVenta.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarVenta.OnIdleState.IconLeftImage")));
            this.btnAgregarVenta.OnIdleState.IconRightImage = null;
            this.btnAgregarVenta.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarVenta.OnPressedState.BorderRadius = 6;
            this.btnAgregarVenta.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarVenta.OnPressedState.BorderThickness = 1;
            this.btnAgregarVenta.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarVenta.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVenta.OnPressedState.IconLeftImage = null;
            this.btnAgregarVenta.OnPressedState.IconRightImage = null;
            this.btnAgregarVenta.Size = new System.Drawing.Size(166, 36);
            this.btnAgregarVenta.TabIndex = 24;
            this.btnAgregarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarVenta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarVenta.TextMarginLeft = 0;
            this.btnAgregarVenta.TextPadding = new System.Windows.Forms.Padding(0, 1, 8, 0);
            this.btnAgregarVenta.UseDefaultRadiusAndThickness = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(50, 206);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 26;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.AcceptsReturn = false;
            this.txtFiltro.AcceptsTab = false;
            this.txtFiltro.AnimationSpeed = 200;
            this.txtFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFiltro.BackgroundImage")));
            this.txtFiltro.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtFiltro.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFiltro.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtFiltro.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtFiltro.BorderRadius = 6;
            this.txtFiltro.BorderThickness = 1;
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.DefaultFont = new System.Drawing.Font("Poppins", 11F);
            this.txtFiltro.DefaultText = "";
            this.txtFiltro.FillColor = System.Drawing.Color.White;
            this.txtFiltro.HideSelection = true;
            this.txtFiltro.IconLeft = null;
            this.txtFiltro.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.IconPadding = 10;
            this.txtFiltro.IconRight = null;
            this.txtFiltro.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(40, 197);
            this.txtFiltro.MaximumSize = new System.Drawing.Size(325, 36);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFiltro.Modified = false;
            this.txtFiltro.Multiline = false;
            this.txtFiltro.Name = "txtFiltro";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltro.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFiltro.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltro.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltro.OnIdleState = stateProperties4;
            this.txtFiltro.Padding = new System.Windows.Forms.Padding(3);
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtFiltro.PlaceholderText = "Buscar ID . . . ";
            this.txtFiltro.ReadOnly = false;
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(165, 36);
            this.txtFiltro.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFiltro.TabIndex = 25;
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiltro.TextMarginBottom = 0;
            this.txtFiltro.TextMarginLeft = 25;
            this.txtFiltro.TextMarginTop = 0;
            this.txtFiltro.TextPlaceholder = "Buscar ID . . . ";
            this.txtFiltro.UseSystemPasswordChar = false;
            this.txtFiltro.WordWrap = true;
            this.txtFiltro.TextChange += new System.EventHandler(this.txtFiltro_TextChange);
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.Font = new System.Drawing.Font("Poppins Medium", 21.75F);
            this.bunifuLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.bunifuLabel10.Location = new System.Drawing.Point(30, 46);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(288, 51);
            this.bunifuLabel10.TabIndex = 27;
            this.bunifuLabel10.Text = "Gestión de ordenes";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbFiltro
            // 
            this.cbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.cbFiltro.BackgroundColor = System.Drawing.Color.White;
            this.cbFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbFiltro.BorderRadius = 6;
            this.cbFiltro.Color = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltro.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbFiltro.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbFiltro.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbFiltro.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbFiltro.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbFiltro.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFiltro.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbFiltro.FillDropDown = true;
            this.cbFiltro.FillIndicator = false;
            this.cbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFiltro.Font = new System.Drawing.Font("Poppins", 10F);
            this.cbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Icon = null;
            this.cbFiltro.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbFiltro.IndicatorColor = System.Drawing.Color.Gray;
            this.cbFiltro.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbFiltro.ItemBackColor = System.Drawing.Color.White;
            this.cbFiltro.ItemBorderColor = System.Drawing.Color.White;
            this.cbFiltro.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbFiltro.ItemHeight = 30;
            this.cbFiltro.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbFiltro.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Activas",
            "En Proceso",
            "Lista",
            "Servida",
            "Cerrada",
            "Cancelada"});
            this.cbFiltro.ItemTopMargin = 6;
            this.cbFiltro.Location = new System.Drawing.Point(256, 197);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(0);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(166, 36);
            this.cbFiltro.TabIndex = 41;
            this.cbFiltro.Text = null;
            this.cbFiltro.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbFiltro.TextLeftMargin = 5;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Poppins Medium", 11F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(256, 165);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(52, 26);
            this.bunifuLabel3.TabIndex = 40;
            this.bunifuLabel3.Text = "Estado";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowCustomTheming = true;
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.ColumnHeadersHeight = 55;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleID,
            this.Fecha,
            this.Total,
            this.EstadoImg,
            this.Estado,
            this.editar,
            this.imprimir,
            this.eliminar});
            this.dgvVentas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVentas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvVentas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvVentas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvVentas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvVentas.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvVentas.CurrentTheme.GridColor = System.Drawing.Color.White;
            this.dgvVentas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvVentas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.dgvVentas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVentas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvVentas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvVentas.CurrentTheme.Name = null;
            this.dgvVentas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVentas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvVentas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvVentas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvVentas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.White;
            this.dgvVentas.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvVentas.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvVentas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvVentas.Location = new System.Drawing.Point(40, 268);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowTemplate.Height = 60;
            this.dgvVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(1018, 382);
            this.dgvVentas.TabIndex = 42;
            this.dgvVentas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenes_CellContentClick);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Poppins Medium", 11F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(40, 165);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(15, 26);
            this.bunifuLabel1.TabIndex = 43;
            this.bunifuLabel1.Text = "ID";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pdRecibo
            // 
            this.pdRecibo.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdRecibo_PrintPage);
            // 
            // ppdRecibo
            // 
            this.ppdRecibo.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdRecibo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdRecibo.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdRecibo.Enabled = true;
            this.ppdRecibo.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdRecibo.Icon")));
            this.ppdRecibo.Name = "ppdRecibo";
            this.ppdRecibo.Visible = false;
            // 
            // saleID
            // 
            this.saleID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.saleID.FillWeight = 130.779F;
            this.saleID.Frozen = true;
            this.saleID.HeaderText = "ID";
            this.saleID.Name = "saleID";
            this.saleID.ReadOnly = true;
            this.saleID.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 200;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 200;
            // 
            // EstadoImg
            // 
            this.EstadoImg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EstadoImg.HeaderText = "";
            this.EstadoImg.Name = "EstadoImg";
            this.EstadoImg.ReadOnly = true;
            this.EstadoImg.Width = 50;
            // 
            // Estado
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.FillWeight = 67.70091F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.editar.DefaultCellStyle = dataGridViewCellStyle4;
            this.editar.FillWeight = 60.9137F;
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.MinimumWidth = 30;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.Width = 30;
            // 
            // imprimir
            // 
            this.imprimir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.imprimir.DefaultCellStyle = dataGridViewCellStyle5;
            this.imprimir.FillWeight = 60.9137F;
            this.imprimir.HeaderText = "";
            this.imprimir.Image = ((System.Drawing.Image)(resources.GetObject("imprimir.Image")));
            this.imprimir.MinimumWidth = 30;
            this.imprimir.Name = "imprimir";
            this.imprimir.ReadOnly = true;
            this.imprimir.Width = 30;
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle6;
            this.eliminar.FillWeight = 60.9137F;
            this.eliminar.HeaderText = "";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.MinimumWidth = 30;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Width = 30;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 699);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel10);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAgregarVenta);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarVenta;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtFiltro;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        public Bunifu.UI.WinForms.BunifuDropdown cbFiltro;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvVentas;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Drawing.Printing.PrintDocument pdRecibo;
        private System.Windows.Forms.PrintPreviewDialog ppdRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn EstadoImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn imprimir;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}