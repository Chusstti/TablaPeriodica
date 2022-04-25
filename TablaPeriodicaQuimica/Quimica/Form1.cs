using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quimica
{
    public partial class fmrElements : Form
    {
        List<Element> ListOfElements = new List<Element>();

        public fmrElements()
        {
            InitializeComponent();
        }

        //Evento que se ejecuta antes que se cargue el formulario
        private void fmrElements_Load(object sender, EventArgs e)
        {
            ListOfElements = Element.GetAllElements();
            FillComboBoxElementName();
        }

        //Metodo que carga el combo con los nombres de los elementos
        private void FillComboBoxElementName()
        {
            cbName.DataSource = ListOfElements;
            cbName.DisplayMember = "Name";
            cbName.ValueMember = "AtomicNumber";
        }

        #region Clicks Events

        private void btnHidrogeno_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(1);
            SetLabels(element);
        }

        private void btnHelio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(2);
            SetLabels(element);

        }

        private void btnLitio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(3);
            SetLabels(element);
        }

        private void btnBerilio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(4);
            SetLabels(element);
        }

        private void btnBoro_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(5);
            SetLabels(element);
        }

        private void btnCarbono_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(6);
            SetLabels(element);
        }

        private void btnNitrogeno_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(7);
            SetLabels(element);
        }

        private void btnOxigeno_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(8);
            SetLabels(element);
        }

        private void btnFluor_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(9);
            SetLabels(element);
        }

        private void btnNeon_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(10);
            SetLabels(element);
        }

        private void btnSodio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(11);
            SetLabels(element);
        }

        private void btnMagnesio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(12);
            SetLabels(element);
        }

        private void btnAluminio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(13);
            SetLabels(element);
        }

        private void btnSilicio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(14);
            SetLabels(element);
        }

        private void btnFosforo_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(15);
            SetLabels(element);
        }

        private void btnAsufre_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(16);
            SetLabels(element);
        }

        private void btnCloro_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(17);
            SetLabels(element);
        }

        private void btnArgon_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(18);
            SetLabels(element);
        }

        private void btnPotasio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(19);
            SetLabels(element);
        }

        private void btnCalcio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(20);
            SetLabels(element);
        }

        private void btnEscandio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(21);
            SetLabels(element);
        }

        private void btnTitanio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(22);
            SetLabels(element);
        }

        private void btnVanadio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(23);
            SetLabels(element);
        }

        private void btnCromo_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(24);
            SetLabels(element);
        }

        private void btnMagneso_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(25);
            SetLabels(element);
        }

        private void btnHierro_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(26);
            SetLabels(element);
        }

        private void btnCobaldo_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(27);
            SetLabels(element);
        }

        private void btnNiquel_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(28);
            SetLabels(element);
        }

        private void btnCobre_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(29);
            SetLabels(element);
        }

        private void btnCinc_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(30);
            SetLabels(element);
        }

        private void btnGalio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(31);
            SetLabels(element);

        }

        private void btnGermanio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(32);
            SetLabels(element);
        }

        private void btnArsenico_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(33);
            SetLabels(element);
        }

        private void btnSelenio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(34);
            SetLabels(element);
        }

        private void btnBromo_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(35);
            SetLabels(element);
        }

        private void btnCripton_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(36);
            SetLabels(element);
        }

        private void btnRubidio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(37);
            SetLabels(element);
        }

        private void btnEstroncio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(38);
            SetLabels(element);
        }

        private void btnItrio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(39);
            SetLabels(element);
        }

        private void btnCirconio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(40);
            SetLabels(element);
        }

        private void btnNiobio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(41);
            SetLabels(element);
        }

        private void btnMolibdeno_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(42);
            SetLabels(element);
        }

        private void btnTecnecio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(43);
            SetLabels(element);
        }

        private void btnRutenio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(44);
            SetLabels(element);
        }

        private void btnRodio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(45);
            SetLabels(element);
        }

        private void btnPaladio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(46);
            SetLabels(element);
        }

        private void btnPlata_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(47);
            SetLabels(element);
        }

        private void btnCadmio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(48);
            SetLabels(element);
        }

        private void btnIndio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(49);
            SetLabels(element);
        }

        private void btnEstaño_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(50);
            SetLabels(element);
        }

        private void btnAntimonio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(51);
            SetLabels(element);
        }

        private void btnTelurio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(52);
            SetLabels(element);
        }

        private void btnYodo_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(53);
            SetLabels(element);
        }

        private void btnXenon_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(54);
            SetLabels(element);
        }

        private void btnCesio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(55);
            SetLabels(element);
        }

        private void btnBario_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(56);
            SetLabels(element);
        }

        private void btnLantano_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(57);
            SetLabels(element);
        }

        private void btnHafnio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(72);
            SetLabels(element);
        }

        private void btnTantalio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(73);
            SetLabels(element);
        }

        private void btnWolframio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(74);
            SetLabels(element);
        }

        private void btnRenio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(75);
            SetLabels(element);
        }

        private void btnOsmio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(76);
            SetLabels(element);
        }

        private void btnIridio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(77);
            SetLabels(element);
        }

        private void btnPlatino_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(78);
            SetLabels(element);
        }

        private void btnOro_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(79);
            SetLabels(element);
        }

        private void btnMercurio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(80);
            SetLabels(element);
        }

        private void btnTalio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(81);
            SetLabels(element);
        }

        private void btnPlomo_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(82);
            SetLabels(element);
        }

        private void btnBismuto_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(83);
            SetLabels(element);
        }

        private void btnPolonio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(84);
            SetLabels(element);
        }

        private void btnAstato_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(85);
            SetLabels(element);
        }

        private void btnRadon_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(86);
            SetLabels(element);
        }

        private void btnFrancio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(87);
            SetLabels(element);
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(88);
            SetLabels(element);
        }

        private void btnActinio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(89);
            SetLabels(element);
        }

        private void btnRutherfodio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(104);
            SetLabels(element);
        }

        private void btnDubnio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(105);
            SetLabels(element);
        }

        private void btnSeaborgio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(106);
            SetLabels(element);
        }

        private void btnBohrio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(107);
            SetLabels(element);
        }

        private void btnHassio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(108);
            SetLabels(element);
        }

        private void btnMeitnerio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(109);
            SetLabels(element);
        }

        private void btnUnunilio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(110);
            SetLabels(element);
        }

        private void btnUnununio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(111);
            SetLabels(element);
        }

        private void btnUnunbio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(112);
            SetLabels(element);
        }

        private void btnUnuntrio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(113);
            SetLabels(element);
        }

        private void btnUnunquadio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(114);
            SetLabels(element);
        }

        private void btnUnunpentio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(115);
            SetLabels(element);
        }

        private void btnUnunhexio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(116);
            SetLabels(element);
        }

        private void btnUnunseptio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(117);
            SetLabels(element);
        }

        private void btnUnunoctio_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element = FindElementsByAtomicNumber(118);
            SetLabels(element);
        }

        #endregion

        #region Methods

        private void RemoveColor(string ControlName)
        {
            //SystemColors.Control;
            Button button = new Button();
            button = (Button)this.Controls.Find(ControlName, true).FirstOrDefault();
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Standard;
            button.FlatAppearance.BorderSize = 1;
            button.Font = new Font(button.Font.Name, button.Font.Size, FontStyle.Regular);
        }


        private void SetLabels(Element element)
        {
            lblSymbol.Text = element.Symbol;
            lblAtomicNumber.Text = element.AtomicNumber.ToString();
            lblName.Text = element.Name;
            lblAtomicMass.Text = element.AtomicMass.ToString();
            lblElectronegativity.Text = element.Electronegativity.ToString();

            //Seteo Color al Botón
            AddColor(element.ControlName);
        }

        private Element FindElementsByAtomicNumber(int AtomicNumber)
        {
            Element element = ListOfElements.FirstOrDefault(x => x.AtomicNumber == AtomicNumber);
            return element;
        }

        //Pinta de color el boton seleccionado
        private void AddColor(string ControlName)
        {
            Button button = new Button();
            button = (Button)this.Controls.Find(ControlName, true).FirstOrDefault();
            //button[0].BackColor = Color.Aqua;
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Popup;
            button.FlatAppearance.BorderSize = 20;
            button.Font = new Font(button.Font.Name, button.Font.Size, FontStyle.Bold);
        }


        #endregion

        //Evento que se dispara cuando el combo cambia
        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Element elementSelected = (Element)cbName.SelectedItem;
            if (elementSelected != null)
            {
                SetLabels(elementSelected);
            }

            Button btn = (Button)this.Controls.Find(elementSelected.ControlName, true).FirstOrDefault();
            btn.Focus();
        }

        //Evento click del boton buscar por grupo y periodo
        private void btnSearchGP_Click(object sender, EventArgs e)
        {
            int Group = (int)nudGroup.Value;
            int Period = (int)nudPeriod.Value;

            //Esta linea busca el primer elemento que coincida con grupo y periodo
            Element element = ListOfElements.FirstOrDefault(x => x.Group == Group && x.Period == Period);
            if (element != null)
            {
                SetLabels(element);
            }

            //Estas dos lineas se usan para despues de agregar efectos de borde y negrita al boton que se selecciono,
            //sacarle el foco porque sino queda como "seleccionado"
            Button btn = (Button)this.Controls.Find(element.ControlName, true).FirstOrDefault();
            btn.Focus();
        }

        #region Events Leave Focus

        private void btnHidrogeno_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnHidrogeno");
        }

        private void btnHelio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnHelio");
        }

        private void btnLitio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnLitio");
        }

        private void btnBerilio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnBerilio");
        }

        private void btnBoro_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnBoro");
        }

        private void btnCarbono_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCarbono");
        }

        private void btnNitrogeno_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnNitrogeno");
        }

        private void btnOxigeno_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnOxigeno");
        }

        private void btnFluor_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnFluor");
        }

        private void btnNeon_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnNeon");
        }

        private void btnSodio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnSodio");
        }

        private void btnMagnesio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnMagnesio");
        }

        private void btnAluminio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnAluminio");
        }

        private void btnSilicio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnSilicio");
        }

        private void btnFosforo_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnFosforo");
        }

        private void btnAzufre_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnAzufre");
        }

        private void btnCloro_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCloro");
        }

        private void btnArgon_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnArgon");
        }

        private void btnPotasio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnPotasio");
        }

        private void btnCalcio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCalcio");
        }

        private void btnEscandio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnEscandio");
        }

        private void btnTitanio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnTitanio");
        }

        private void btnVanadio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnVanadio");
        }

        private void btnCromo_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCromo");
        }

        private void btnMagneso_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnMagneso");
        }

        private void btnHierro_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnHierro");
        }

        private void btnCobalto_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCobalto");
        }

        private void btnNiquel_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnNiquel");
        }

        private void btnCobre_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCobre");
        }

        private void btnCinc_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCinc");
        }

        private void btnGalio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnGalio");
        }

        private void btnGermanio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnGermanio");
        }

        private void btnArsenico_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnArsenico");
        }

        private void btnSelenio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnSelenio");
        }

        private void btnBromo_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnBromo");
        }

        private void btnCripton_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCripton");
        }

        private void btnRubidio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnRubidio");
        }

        private void btnEstroncio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnEstroncio");
        }

        private void btnItrio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnItrio");
        }

        private void btnCirconio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCirconio");
        }

        private void btnNiobio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnNiobio");
        }

        private void btnMolibdeno_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnMolibdeno");
        }

        private void btnTecnecio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnTecnecio");
        }

        private void btnRutenio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnRutenio");
        }

        private void btnRodio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnRodio");
        }

        private void btnPaladio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnPaladio");
        }

        private void btnPlata_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnPlata");
        }

        private void btnCadmio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCadmio");
        }

        private void btnIndio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnIndio");
        }

        private void btnEstanio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnEstanio");
        }

        private void btnAntimonio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnAntimonio");
        }

        private void btnTelurio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnTelurio");
        }

        private void btnYodo_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnYodo");
        }

        private void btnXenon_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnXenon");
        }

        private void btnCesio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnCesio");
        }

        private void btnBario_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnBario");
        }

        private void btnLantano_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnLantano");
        }

        private void btnHafnio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnHafnio");
        }

        private void btnTantalio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnTantalio");
        }

        private void btnWolframio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnWolframio");
        }

        private void btnRenio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnRenio");
        }

        private void btnOsmio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnOsmio");
        }

        private void btnIridio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnIridio");
        }

        private void btnPlatino_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnPlatino");
        }

        private void btnOro_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnOro");
        }

        private void btnMercurio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnMercurio");
        }

        private void btnTalio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnTalio");
        }

        private void btnPlomo_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnPlomo");
        }

        private void btnBismuto_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnBismuto");
        }

        private void btnPolonio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnPolonio");
        }

        private void btnAstato_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnAstato");
        }

        private void btnRadon_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnRadon");
        }

        private void btnFrancio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnFrancio");
        }

        private void btnRadio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnRadio");
        }

        private void btnActinio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnActinio");
        }

        private void btnRutherfordio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnRutherfordio");
        }

        private void btnDubnio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnDubnio");
        }

        private void btnSeaborgio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnSeaborgio");
        }

        private void btnBohrio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnBohrio");
        }

        private void btnHassio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnHassio");
        }

        private void btnMeitnerio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnMeitnerio");
        }

        private void btnUnunilio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnUnunilio");
        }

        private void btnUnununio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnUnununio");
        }

        private void btnUnunbio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnUnunbio");
        }

        private void btnUnuntrio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnUnuntrio");
        }

        private void btnUnunquadio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnUnunquadio");
        }

        private void btnUnunpentio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnUnunpentio");
        }

        private void btnUnunhexio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnUnunhexio");
        }

        private void btnUnunseptio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnUnunseptio");
        }

        private void btnUnunoctio_Leave(object sender, EventArgs e)
        {
            RemoveColor("btnUnunoctio");
        }


        #endregion

        private void cbName_Click(object sender, EventArgs e)
        {
            //FillComboBoxElementName();
        }
    }
}
