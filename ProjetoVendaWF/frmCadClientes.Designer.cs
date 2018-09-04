namespace ProjetoVendaWF
{
    partial class frmCadClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadClientes));
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.maskCelular = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskCEP = new System.Windows.Forms.MaskedTextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.gpbSexo.SuspendLayout();
            this.gpbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(738, 123);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(44, 21);
            this.cbEstado.TabIndex = 10;
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbMunicipio.Items.AddRange(new object[] {
            "",
            "ACEGUÁ",
            "ÁGUA SANTA",
            "AGUDO",
            "AJURICABA",
            "ALECRIM",
            "ALEGRETE",
            "ALEGRIA",
            "ALMIRANTE TAMANDARÉ DO SUL",
            "ALPESTRE",
            "ALTO ALEGRE",
            "ALTO FELIZ",
            "ALVORADA",
            "AMARAL FERRADOR",
            "AMETISTA DO SUL",
            "ANDRÉ DA ROCHA",
            "ANTA GORDA",
            "ANTÔNIO PRADO",
            "ARAMBARÉ",
            "ARARICÁ",
            "ARATIBA",
            "ARROIO DO MEIO",
            "ARROIO DO PADRE",
            "ARROIO DO SAL",
            "ARROIO DO TIGRE",
            "ARROIO DOS RATOS",
            "ARROIO GRANDE",
            "ARVOREZINHA",
            "AUGUSTO PESTANA",
            "ÁUREA",
            "BAGÉ",
            "BALNEÁRIO PINHAL",
            "BARÃO",
            "BARÃO DE COTEGIPE",
            "BARÃO DO TRIUNFO",
            "BARRA DO GUARITA",
            "BARRA DO QUARAÍ",
            "BARRA DO RIBEIRO",
            "BARRA DO RIO AZUL",
            "BARRA FUNDA",
            "BARRACÃO",
            "BARROS CASSAL",
            "BENJAMIN CONSTANT DO SUL",
            "BENTO GONÇALVES",
            "BOA VISTA DAS MISSÕES",
            "BOA VISTA DO BURICÁ",
            "BOA VISTA DO CADEADO",
            "BOA VISTA DO INCRA",
            "BOA VISTA DO SUL",
            "BOM JESUS",
            "BOM PRINCÍPIO",
            "BOM PROGRESSO",
            "BOM RETIRO DO SUL",
            "BOQUEIRÃO DO LEÃO",
            "BOSSOROCA",
            "BOZANO",
            "BRAGA",
            "BROCHIER",
            "BUTIÁ",
            "CAÇAPAVA DO SUL",
            "CACEQUI",
            "CACHOEIRA DO SUL",
            "CACHOEIRINHA",
            "CACIQUE DOBLE",
            "CAIBATÉ",
            "CAIÇARA",
            "CAMAQUÃ",
            "CAMARGO",
            "CAMBARÁ DO SUL",
            "CAMPESTRE DA SERRA",
            "CAMPINA DAS MISSÕES",
            "CAMPINAS DO SUL",
            "CAMPO BOM",
            "CAMPO NOVO",
            "CAMPOS BORGES",
            "CANDELÁRIA",
            "CÂNDIDO GODÓI",
            "CANDIOTA",
            "CANELA",
            "CANGUÇU",
            "CANOAS",
            "CANUDOS DO VALE",
            "CAPÃO BONITO DO SUL",
            "CAPÃO DA CANOA",
            "CAPÃO DO CIPÓ",
            "CAPÃO DO LEÃO",
            "CAPELA DE SANTANA",
            "CAPITÃO",
            "CAPIVARI DO SUL",
            "CARAÁ",
            "CARAZINHO",
            "CARLOS BARBOSA",
            "CARLOS GOMES",
            "CASCA",
            "CASEIROS",
            "CATUÍPE",
            "CAXIAS DO SUL",
            "CENTENÁRIO",
            "CERRITO",
            "CERRO BRANCO",
            "CERRO GRANDE",
            "CERRO GRANDE DO SUL",
            "CERRO LARGO",
            "CHAPADA",
            "CHARQUEADAS",
            "CHARRUA",
            "CHIAPETTA",
            "CHUÍ",
            "CHUVISCA",
            "CIDREIRA",
            "CIRÍACO",
            "COLINAS",
            "COLORADO",
            "CONDOR",
            "CONSTANTINA",
            "COQUEIRO BAIXO",
            "COQUEIROS DO SUL",
            "CORONEL BARROS",
            "CORONEL BICACO",
            "CORONEL PILAR",
            "COTIPORÃ",
            "COXILHA",
            "CRISSIUMAL",
            "CRISTAL",
            "CRISTAL DO SUL",
            "CRUZ ALTA",
            "CRUZALTENSE",
            "CRUZEIRO DO SUL",
            "DAVID CANABARRO",
            "DERRUBADAS",
            "DEZESSEIS DE NOVEMBRO",
            "DILERMANDO DE AGUIAR",
            "DOIS IRMÃOS",
            "DOIS IRMÃOS DAS MISSÕES",
            "DOIS LAJEADOS",
            "DOM FELICIANO",
            "DOM PEDRITO",
            "DOM PEDRO DE ALCÂNTARA",
            "DONA FRANCISCA",
            "DOUTOR MAURÍCIO CARDOSO",
            "DOUTOR RICARDO",
            "ELDORADO DO SUL",
            "ENCANTADO",
            "ENCRUZILHADA DO SUL",
            "ENGENHO VELHO",
            "ENTRE RIOS DO SUL",
            "ENTRE-IJUÍS",
            "EREBANGO",
            "ERECHIM",
            "ERNESTINA",
            "ERVAL GRANDE",
            "ERVAL SECO",
            "ESMERALDA",
            "ESPERANÇA DO SUL",
            "ESPUMOSO",
            "ESTAÇÃO",
            "ESTÂNCIA VELHA",
            "ESTEIO",
            "ESTRELA",
            "ESTRELA VELHA",
            "EUGÊNIO DE CASTRO",
            "FAGUNDES VARELA",
            "FARROUPILHA",
            "FAXINAL DO SOTURNO",
            "FAXINALZINHO",
            "FAZENDA VILANOVA",
            "FELIZ",
            "FLORES DA CUNHA",
            "FLORIANO PEIXOTO",
            "FONTOURA XAVIER",
            "FORMIGUEIRO",
            "FORQUETINHA",
            "FORTALEZA DOS VALOS",
            "FREDERICO WESTPHALEN",
            "GARIBALDI",
            "GARRUCHOS",
            "GAURAMA",
            "GENERAL CÂMARA",
            "GENTIL",
            "GETÚLIO VARGAS",
            "GIRUÁ",
            "GLORINHA",
            "GRAMADO",
            "GRAMADO DOS LOUREIROS",
            "GRAMADO XAVIER",
            "GRAVATAÍ",
            "GUABIJU",
            "GUAÍBA",
            "GUAPORÉ",
            "GUARANI DAS MISSÕES",
            "HARMONIA",
            "HERVAL",
            "HERVEIRAS",
            "HORIZONTINA",
            "HULHA NEGRA",
            "HUMAITÁ",
            "IBARAMA",
            "IBIAÇÁ",
            "IBIRAIARAS",
            "IBIRAPUITÃ",
            "IBIRUBÁ",
            "IGREJINHA",
            "IJUÍ",
            "ILÓPOLIS",
            "IMBÉ",
            "IMIGRANTE",
            "INDEPENDÊNCIA",
            "INHACORÁ",
            "IPÊ",
            "IPIRANGA DO SUL",
            "IRAÍ",
            "ITAARA",
            "ITACURUBI",
            "ITAPUCA",
            "ITAQUI",
            "ITATI",
            "ITATIBA DO SUL",
            "IVORÁ",
            "IVOTI",
            "JABOTICABA",
            "JACUIZINHO",
            "JACUTINGA",
            "JAGUARÃO",
            "JAGUARI",
            "JAQUIRANA",
            "JARI",
            "JÓIA",
            "JÚLIO DE CASTILHOS",
            "LAGOA BONITA DO SUL",
            "LAGOA DOS TRÊS CANTOS",
            "LAGOA VERMELHA",
            "LAGOÃO",
            "LAJEADO",
            "LAJEADO DO BUGRE",
            "LAVRAS DO SUL",
            "LIBERATO SALZANO",
            "LINDOLFO COLLOR",
            "LINHA NOVA",
            "MAÇAMBARA",
            "MACHADINHO",
            "MAMPITUBA",
            "MANOEL VIANA",
            "MAQUINÉ",
            "MARATÁ",
            "MARAU",
            "MARCELINO RAMOS",
            "MARIANA PIMENTEL",
            "MARIANO MORO",
            "MARQUES DE SOUZA",
            "MATA",
            "MATO CASTELHANO",
            "MATO LEITÃO",
            "MATO QUEIMADO",
            "MAXIMILIANO DE ALMEIDA",
            "MINAS DO LEÃO",
            "MIRAGUAÍ",
            "MONTAURI",
            "MONTE ALEGRE DOS CAMPOS",
            "MONTE BELO DO SUL",
            "MONTENEGRO",
            "MORMAÇO",
            "MORRINHOS DO SUL",
            "MORRO REDONDO",
            "MORRO REUTER",
            "MOSTARDAS",
            "MUÇUM",
            "MUITOS CAPÕES",
            "MULITERNO",
            "NÃO-ME-TOQUE",
            "NICOLAU VERGUEIRO",
            "NONOAI",
            "NOVA ALVORADA",
            "NOVA ARAÇÁ",
            "NOVA BASSANO",
            "NOVA BOA VISTA",
            "NOVA BRÉSCIA",
            "NOVA CANDELÁRIA",
            "NOVA ESPERANÇA DO SUL",
            "NOVA HARTZ",
            "NOVA PÁDUA",
            "NOVA PALMA",
            "NOVA PETRÓPOLIS",
            "NOVA PRATA",
            "NOVA RAMADA",
            "NOVA ROMA DO SUL",
            "NOVA SANTA RITA",
            "NOVO BARREIRO",
            "NOVO CABRAIS",
            "NOVO HAMBURGO",
            "NOVO MACHADO",
            "NOVO TIRADENTES",
            "NOVO XINGU",
            "OSÓRIO",
            "PAIM FILHO",
            "PALMARES DO SUL",
            "PALMEIRA DAS MISSÕES",
            "PALMITINHO",
            "PANAMBI",
            "PANTANO GRANDE",
            "PARAÍ",
            "PARAÍSO DO SUL",
            "PARECI NOVO",
            "PAROBÉ",
            "PASSA SETE",
            "PASSO DO SOBRADO",
            "PASSO FUNDO",
            "PAULO BENTO",
            "PAVERAMA",
            "PEDRAS ALTAS",
            "PEDRO OSÓRIO",
            "PEJUÇARA",
            "PELOTAS",
            "PICADA CAFÉ",
            "PINHAL",
            "PINHAL DA SERRA",
            "PINHAL GRANDE",
            "PINHEIRINHO DO VALE",
            "PINHEIRO MACHADO",
            "PIRAPÓ",
            "PIRATINI",
            "PLANALTO",
            "POÇO DAS ANTAS",
            "PONTÃO",
            "PONTE PRETA",
            "PORTÃO",
            "PORTO ALEGRE",
            "PORTO LUCENA",
            "PORTO MAUÁ",
            "PORTO VERA CRUZ",
            "PORTO XAVIER",
            "POUSO NOVO",
            "PRESIDENTE LUCENA",
            "PROGRESSO",
            "PROTÁSIO ALVES",
            "PUTINGA",
            "QUARAÍ",
            "QUATRO IRMÃOS",
            "QUEVEDOS",
            "QUINZE DE NOVEMBRO",
            "REDENTORA",
            "RELVADO",
            "RESTINGA SECA",
            "RIO DOS ÍNDIOS",
            "RIO GRANDE",
            "RIO PARDO",
            "RIOZINHO",
            "ROCA SALES",
            "RODEIO BONITO",
            "ROLADOR",
            "ROLANTE",
            "RONDA ALTA",
            "RONDINHA",
            "ROQUE GONZALES",
            "ROSÁRIO DO SUL",
            "SAGRADA FAMÍLIA",
            "SALDANHA MARINHO",
            "SALTO DO JACUÍ",
            "SALVADOR DAS MISSÕES",
            "SALVADOR DO SUL",
            "SANANDUVA",
            "SANTA BÁRBARA DO SUL",
            "SANTA CECÍLIA DO SUL",
            "SANTA CLARA DO SUL",
            "SANTA CRUZ DO SUL",
            "SANTA MARGARIDA DO SUL",
            "SANTA MARIA",
            "SANTA MARIA DO HERVAL",
            "SANTA ROSA",
            "SANTA TEREZA",
            "SANTA VITÓRIA DO PALMAR",
            "SANTANA DA BOA VISTA",
            "SANTANA DO LIVRAMENTO",
            "SANTIAGO",
            "SANTO ÂNGELO",
            "SANTO ANTÔNIO DA PATRULHA",
            "SANTO ANTÔNIO DAS MISSÕES",
            "SANTO ANTÔNIO DO PALMA",
            "SANTO ANTÔNIO DO PLANALTO",
            "SANTO AUGUSTO",
            "SANTO CRISTO",
            "SANTO EXPEDITO DO SUL",
            "SÃO BORJA",
            "SÃO DOMINGOS DO SUL",
            "SÃO FRANCISCO DE ASSIS",
            "SÃO FRANCISCO DE PAULA",
            "SÃO GABRIEL",
            "SÃO JERÔNIMO",
            "SÃO JOÃO DA URTIGA",
            "SÃO JOÃO DO POLÊSINE",
            "SÃO JORGE",
            "SÃO JOSÉ DAS MISSÕES",
            "SÃO JOSÉ DO HERVAL",
            "SÃO JOSÉ DO HORTÊNCIO",
            "SÃO JOSÉ DO INHACORÁ",
            "SÃO JOSÉ DO NORTE",
            "SÃO JOSÉ DO OURO",
            "SÃO JOSÉ DO SUL",
            "SÃO JOSÉ DOS AUSENTES",
            "SÃO LEOPOLDO",
            "SÃO LOURENÇO DO SUL",
            "SÃO LUIZ GONZAGA",
            "SÃO MARCOS",
            "SÃO MARTINHO",
            "SÃO MARTINHO DA SERRA",
            "SÃO MIGUEL DAS MISSÕES",
            "SÃO NICOLAU",
            "SÃO PAULO DAS MISSÕES",
            "SÃO PEDRO DA SERRA",
            "SÃO PEDRO DAS MISSÕES",
            "SÃO PEDRO DO BUTIÁ",
            "SÃO PEDRO DO SUL",
            "SÃO SEBASTIÃO DO CAÍ",
            "SÃO SEPÉ",
            "SÃO VALENTIM",
            "SÃO VALENTIM DO SUL",
            "SÃO VALÉRIO DO SUL",
            "SÃO VENDELINO",
            "SÃO VICENTE DO SUL",
            "SAPIRANGA",
            "SAPUCAIA DO SUL",
            "SARANDI",
            "SEBERI",
            "SEDE NOVA",
            "SEGREDO",
            "SELBACH",
            "SENADOR SALGADO FILHO",
            "SENTINELA DO SUL",
            "SERAFINA CORRÊA",
            "SÉRIO",
            "SERTÃO",
            "SERTÃO SANTANA",
            "SETE DE SETEMBRO",
            "SEVERIANO DE ALMEIDA",
            "SILVEIRA MARTINS",
            "SINIMBU",
            "SOBRADINHO",
            "SOLEDADE",
            "TABAÍ",
            "TAPEJARA",
            "TAPERA",
            "TAPES",
            "TAQUARA",
            "TAQUARI",
            "TAQUARUÇU DO SUL",
            "TAVARES",
            "TENENTE PORTELA",
            "TERRA DE AREIA",
            "TEUTÔNIA",
            "TIO HUGO",
            "TIRADENTES DO SUL",
            "TOROPI",
            "TORRES",
            "TRAMANDAÍ",
            "TRAVESSEIRO",
            "TRÊS ARROIOS",
            "TRÊS CACHOEIRAS",
            "TRÊS COROAS",
            "TRÊS DE MAIO",
            "TRÊS FORQUILHAS",
            "TRÊS PALMEIRAS",
            "TRÊS PASSOS",
            "TRINDADE DO SUL",
            "TRIUNFO",
            "TUCUNDUVA",
            "TUNAS",
            "TUPANCI DO SUL",
            "TUPANCIRETÃ",
            "TUPANDI",
            "TUPARENDI",
            "TURUÇU",
            "UBIRETAMA",
            "UNIÃO DA SERRA",
            "UNISTALDA",
            "URUGUAIANA",
            "VACARIA",
            "VALE DO SOL",
            "VALE REAL",
            "VALE VERDE",
            "VANINI",
            "VENÂNCIO AIRES",
            "VERA CRUZ",
            "VERANÓPOLIS",
            "VESPASIANO CORREA",
            "VIADUTOS",
            "VIAMÃO",
            "VICENTE DUTRA",
            "VICTOR GRAEFF",
            "VILA FLORES",
            "VILA LÂNGARO",
            "VILA MARIA",
            "VILA NOVA DO SUL",
            "VISTA ALEGRE",
            "VISTA ALEGRE DO PRATA",
            "VISTA GAÚCHA",
            "VITÓRIA DAS MISSÕES",
            "WESTFALIA",
            "XANGRI-LÁ"});
            this.cbMunicipio.Location = new System.Drawing.Point(477, 124);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(252, 21);
            this.cbMunicipio.TabIndex = 9;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(474, 11);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblNascimento.TabIndex = 12;
            this.lblNascimento.Text = "Data Nascimento";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(476, 27);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(105, 20);
            this.dtpNascimento.TabIndex = 2;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtnFeminino);
            this.gpbSexo.Controls.Add(this.rbtnMasculino);
            this.gpbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSexo.Location = new System.Drawing.Point(589, 11);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(194, 38);
            this.gpbSexo.TabIndex = 3;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(111, 13);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 10;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(24, 13);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 10;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(476, 59);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 7;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(369, 108);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(26, 13);
            this.lblCep.TabIndex = 7;
            this.lblCep.Text = "Cep";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(368, 58);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 13);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Nº";
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(477, 75);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(307, 20);
            this.txtComplemento.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(367, 75);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // maskCelular
            // 
            this.maskCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCelular.Location = new System.Drawing.Point(124, 171);
            this.maskCelular.Mask = "(00) 00000-0000";
            this.maskCelular.Name = "maskCelular";
            this.maskCelular.Size = new System.Drawing.Size(105, 20);
            this.maskCelular.TabIndex = 12;
            this.maskCelular.Enter += new System.EventHandler(this.maskCPF_Enter);
            // 
            // maskTelefone
            // 
            this.maskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTelefone.Location = new System.Drawing.Point(10, 171);
            this.maskTelefone.Mask = "(00) 0000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(105, 20);
            this.maskTelefone.TabIndex = 11;
            this.maskTelefone.Enter += new System.EventHandler(this.maskCPF_Enter);
            // 
            // maskCEP
            // 
            this.maskCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCEP.Location = new System.Drawing.Point(367, 124);
            this.maskCEP.Mask = "00000-000";
            this.maskCEP.Name = "maskCEP";
            this.maskCEP.Size = new System.Drawing.Size(100, 20);
            this.maskCEP.TabIndex = 8;
            this.maskCEP.Enter += new System.EventHandler(this.maskCPF_Enter);
            // 
            // maskCPF
            // 
            this.maskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCPF.Location = new System.Drawing.Point(367, 27);
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(100, 20);
            this.maskCPF.TabIndex = 1;
            this.maskCPF.Enter += new System.EventHandler(this.maskCPF_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(239, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(543, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(8, 123);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(350, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(8, 75);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(350, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(736, 108);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(124, 155);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 2;
            this.lblCelular.Text = "Celular";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(476, 108);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(52, 13);
            this.lblMunicipio.TabIndex = 2;
            this.lblMunicipio.Text = "Municipio";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(238, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(7, 156);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(7, 108);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(8, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(7, 59);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 2;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(367, 11);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 1;
            this.lbCPF.Text = "CPF";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(7, 11);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(283, 196);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 25);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(423, 196);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 25);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gpbCliente
            // 
            this.gpbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.gpbCliente.Controls.Add(this.cbEstado);
            this.gpbCliente.Controls.Add(this.btnFechar);
            this.gpbCliente.Controls.Add(this.cbMunicipio);
            this.gpbCliente.Controls.Add(this.btnCadastrar);
            this.gpbCliente.Controls.Add(this.lblNascimento);
            this.gpbCliente.Controls.Add(this.lblEmail);
            this.gpbCliente.Controls.Add(this.dtpNascimento);
            this.gpbCliente.Controls.Add(this.lbNome);
            this.gpbCliente.Controls.Add(this.gpbSexo);
            this.gpbCliente.Controls.Add(this.lbCPF);
            this.gpbCliente.Controls.Add(this.lblComplemento);
            this.gpbCliente.Controls.Add(this.lbEndereco);
            this.gpbCliente.Controls.Add(this.lblCep);
            this.gpbCliente.Controls.Add(this.txtNome);
            this.gpbCliente.Controls.Add(this.lblNumero);
            this.gpbCliente.Controls.Add(this.lblBairro);
            this.gpbCliente.Controls.Add(this.txtComplemento);
            this.gpbCliente.Controls.Add(this.lblTelefone);
            this.gpbCliente.Controls.Add(this.txtNumero);
            this.gpbCliente.Controls.Add(this.lblMunicipio);
            this.gpbCliente.Controls.Add(this.maskCelular);
            this.gpbCliente.Controls.Add(this.lblCelular);
            this.gpbCliente.Controls.Add(this.maskTelefone);
            this.gpbCliente.Controls.Add(this.lblEstado);
            this.gpbCliente.Controls.Add(this.maskCEP);
            this.gpbCliente.Controls.Add(this.txtEndereco);
            this.gpbCliente.Controls.Add(this.maskCPF);
            this.gpbCliente.Controls.Add(this.txtBairro);
            this.gpbCliente.Controls.Add(this.txtEmail);
            this.gpbCliente.Location = new System.Drawing.Point(3, -3);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(789, 230);
            this.gpbCliente.TabIndex = 16;
            this.gpbCliente.TabStop = false;
            // 
            // frmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 228);
            this.Controls.Add(this.gpbCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadClientes";
            this.Text = ".:: Cadastro | Clientes ::.";
            this.Load += new System.EventHandler(this.frmCadClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadClientes_KeyDown);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.MaskedTextBox maskCEP;
        private System.Windows.Forms.MaskedTextBox maskCelular;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gpbCliente;
    }
}