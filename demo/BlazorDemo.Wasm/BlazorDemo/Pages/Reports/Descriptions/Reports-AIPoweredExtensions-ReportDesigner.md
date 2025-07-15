<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

This demo incorporates the following AI-powered functionality into the DevExpress Report Designer:

- **AI Prompt-to-Report** option in our [Report Wizard](https://docs.devexpress.com/XtraReports/400946/web-reporting/end-user-report-designer-for-web/wizards/report-wizard-fullscreen)

    Select **New via Wizard** command from the [Main Menu](https://docs.devexpress.com/XtraReports/17643/web-reporting/end-user-report-designer-for-web/interface-elements/main-menu). In the wizard, select **AI Prompt-to-Report**. This option allows you to describe a report you wish to build (with or without a data source). A generic prompt template and a few predefined prompts are included.

    [Documentation](https://docs.devexpress.com/XtraReports/405485/ai-powered-functionality/web-reporting/prompt-to-report-in-web-report-designer)

- **Smart Preview with AI-generated Data**

    A **Smart Preview** button appears next to default Design/Preview commands in the [Main Toolbar](https://docs.devexpress.com/XtraReports/17552/web-reporting/end-user-report-designer-for-web/interface-elements/main-toolbar). Click this button to display a report preview with AI-generated Test Data (to help prototype your report without an active database connection).

    [Documentation](https://docs.devexpress.com/XtraReports/405467/ai-powered-functionality/web-reporting/test-data-source-in-web-report-designer)

- **AI-powered Localization**

    The [Localization Editor](https://docs.devexpress.com/XtraReports/401584/web-reporting/end-user-report-designer-for-web/interface-elements/localization-editor-webforms) includes a **Localize with AI** button. Select the desired language and click this button to translate all localizable property values to the selected language.

    [Documentation](https://docs.devexpress.com/XtraReports/405401/ai-powered-functionality/web-reporting/localization-in-web-report-designer)

- **AI-powered Prompt-to-Expression Generator**

    Our [Filter Editor](https://docs.devexpress.com/XtraReports/113888/web-reporting/end-user-report-designer-for-web/interface-elements/filter-editor) and [Expression Editor](https://docs.devexpress.com/XtraReports/114059/web-reporting/end-user-report-designer-for-web/interface-elements/expression-editor) display an AI button that invokes the **Prompt-to-Expression Generator**. Enter an expression prompt in natural language and click **Generate**. You can edit the generated expression in the Generator window and apply it when ready.

    [Documentation](https://docs.devexpress.com/XtraReports/405465/ai-powered-functionality/web-reporting/prompt-to-expression-in-web-report-designer)

Note: DevExpress AI-powered Extensions follow the "bring your own key" principle. DevExpress does not offer a REST API and does not ship any built-in LLMs/SLMs. You need an active Azure/Open AI subscription to obtain the REST API endpoint, key, and model deployment name. These variables must be specified at application startup to register AI clients and enable DevExpress AI-powered Extensions in your application.
