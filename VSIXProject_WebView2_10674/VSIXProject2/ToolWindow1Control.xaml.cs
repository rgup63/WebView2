namespace VSIXProject2
{
    using System.Windows.Controls;
    using Microsoft.Web.WebView2.Core;

    /// <summary>
    /// Interaction logic for ToolWindow1Control.
    /// </summary>
    public partial class ToolWindow1Control : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolWindow1Control"/> class.
        /// </summary>
        public ToolWindow1Control()
        {
            this.InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            var env = await CoreWebView2Environment.CreateAsync(null, "C:\\temp");
            await webView.EnsureCoreWebView2Async(env);
        }
    }
}