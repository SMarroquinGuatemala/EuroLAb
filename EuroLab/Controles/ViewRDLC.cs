using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Preview;
using DevExpress.Printing;
using DevExpress.Utils.Menu;
using DevExpress.XtraPrinting;
using Microsoft.Reporting.WinForms;
using DevExpress.XtraEditors.Controls;

namespace Contratos.Controls
{
    public partial class ViewRDLC : DevExpress.XtraEditors.XtraUserControl
    {
        private static ViewRDLC _Instance;
        public static ViewRDLC Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ViewRDLC();
                return _Instance;
            }
        }
        private PrinterImagesContainer imagesContainer = new PrinterImagesContainer();
        private PrinterItemContainer printerItemContainer = new PrinterItemContainer();

        private DXPopupMenu menuExport = new DXPopupMenu();
        public ExportTarget SelectedExport { get; set; }

        #region "Definicion de Propiedades"

        private string _ReportPath;
        public string ReportPath
        {
            get { return _ReportPath; }
            set
            {
                _ReportPath = value;
                viewerRDLC.Reset();
                if (!string.IsNullOrEmpty(ReportPath))
                {
                    viewerRDLC.LocalReport.ReportPath = ReportPath;
                }
                else
                {
                    viewerRDLC.LocalReport.ReportPath = null;
                }

            }
        }

        private ReportDataSource _Datasource;
        public ReportDataSource Datasource
        {
            get { return _Datasource; }
            set
            {
                _Datasource = value;
                if (Datasource != null)
                {
                    viewerRDLC.LocalReport.DataSources.Add(Datasource);
                }
            }
        }

        private DisplayMode _DisplayMode;
        public DisplayMode DisplayMode
        {
            get { return _DisplayMode; }
            set
            {
                _DisplayMode = value;
                viewerRDLC.SetDisplayMode(DisplayMode);
            }
        }

        private ZoomMode _ZoomMode;
        public ZoomMode ZoomMode
        {
            get { return _ZoomMode; }
            set
            {
                _ZoomMode = value;
                viewerRDLC.ZoomMode = ZoomMode;
            }
        }

        private int _ZoomPercent;
        public int ZoomPercent
        {
            get { return _ZoomPercent; }
            set
            {
                _ZoomPercent = value;
                if (ZoomPercent > 0)
                {
                    viewerRDLC.ZoomPercent = ZoomPercent;
                }
            }
        }

        private ProcessingMode? _ProcessingMode;
        public ProcessingMode? ProcessingMode
        {
            get { return _ProcessingMode; }
            set
            {
                _ProcessingMode = value;
                if (ProcessingMode != null)
                {
                    viewerRDLC.ProcessingMode = (ProcessingMode)ProcessingMode;
                }
            }
        }

        private bool _ActualizarReporte;
        public bool ActualizarReporte
        {
            get { return _ActualizarReporte; }
            set
            {
                _ActualizarReporte = value;
                if (ActualizarReporte)
                {
                    viewerRDLC.RefreshReport();
                }
            }
        }

        private string _TituloReporte;
        public string TituloReporte
        {
            get { return _TituloReporte; }
            set
            {
                _TituloReporte = value;
                if (!string.IsNullOrEmpty(TituloReporte))
                {
                    lbltituloreporte.Text = TituloReporte;
                }
            }
        }
        #endregion

        public ViewRDLC()
        {
            InitializeComponent();
        }
        ~ViewRDLC()
        {
            viewerRDLC.Dispose();
            Dispose();
        }

        private void ViewRDLC_Load(object sender, EventArgs e)
        {
            try
            {
                FillImpresoras();
                AddExportTarget(ExportTarget.Pdf);
                AddExportTarget(ExportTarget.Xlsx);
                AddExportTarget(ExportTarget.Text);
                CmdExportar.DropDownControl = menuExport;
                SelectedExport = ExportTarget.Pdf;
                menuExport.BeforePopup += new EventHandler(MenuExport_BeforePopup);
                CmdExportar.Text = string.Format("Exportar {0}", SelectedExport.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FillImpresoras()
        {
            CboImpresoras.Properties.LargeImages = imagesContainer.LargeImages;
            CboImpresoras.Properties.SmallImages = imagesContainer.SmallImages;
            if (printerItemContainer != null)
            {
                foreach (PrinterItem item in printerItemContainer.Items)
                {
                    CboImpresoras.Properties.Items.Add(new ImageComboBoxItem(item.DisplayName, item, imagesContainer.GetImageIndex(item)));
                }
            }
        }

        private void AddExportTarget(ExportTarget target)
        {
            DXMenuCheckItem ExportItem = new DXMenuCheckItem()
            {
                Caption = target.ToString(),
                Tag = target
            };
            ExportItem.Click += new EventHandler(ExportItem_Click);
            menuExport.Items.Add(ExportItem);
        }

        private void ExportItem_Click(object sender, EventArgs e)
        {
            SelectedExport = (ExportTarget)((DXMenuItem)sender).Tag;
            CmdExportar.Text = string.Format("Exportar {0}", SelectedExport.ToString());
        }

        private void MenuExport_BeforePopup(object sender, EventArgs e)
        {
            foreach (DXMenuCheckItem item in menuExport.Items)
            {
                item.Checked = object.Equals(item.Tag, SelectedExport);
            }
        }

        private void CmdImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (CboImpresoras.EditValue != null)
                {
                    viewerRDLC.PrinterSettings.PrinterName = ((PrinterItem)CboImpresoras.EditValue).FullName;
                    viewerRDLC.PrintDialog();
                }
                else
                {
                    XtraMessageBox.Show("No se seleccionado ninguna impresora", "Mensaje Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //Helpers.F_Error(ex, "Imprimrir");
            }
        }

        private void CmdExportar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (SelectedExport)
                {
                    case ExportTarget.Xls:
                        break;
                    case ExportTarget.Xlsx:
                        viewerRDLC.ExportDialog(viewerRDLC.LocalReport.ListRenderingExtensions()[0]);
                        //Excel
                        break;
                    case ExportTarget.Pdf:
                        viewerRDLC.ExportDialog(viewerRDLC.LocalReport.ListRenderingExtensions()[3]);
                        //PDF
                        break;
                    case ExportTarget.Text:
                        viewerRDLC.ExportDialog(viewerRDLC.LocalReport.ListRenderingExtensions()[4]);
                        //Word
                        break;
                    default:
                        break;
                } 
            }
            catch (Exception ex)
            {
                //Helpers.F_Error(ex, "Exportar");
            }
        } 
    }
}
