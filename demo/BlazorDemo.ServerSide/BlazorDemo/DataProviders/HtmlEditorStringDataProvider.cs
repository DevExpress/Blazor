namespace BlazorDemo.DataProviders.Implementation {
    public class HtmlEditorStringDataProvider : IHtmlEditorStringDataProvider {
        public string GetData() {
            return $@"<h2>
                        <img src={StaticAssetUtils.GetImagePath("html-editor/html-editor.svg")} alt='HtmlEditor' />
                        HTML Editor
                    </h2><br>
                    <p>The HTML Editor component for Blazor is a WYSIWYG (what you see is what you get) text editor that allows users to format text and add graphics. The document uses HTML format.</p>
                    <p>Supported features:</p>
                    <ul>
                        <li>Inline formats:
                            <ul>
                                <li><strong>Bold</strong>, <em>italic</em>, <s>strikethrough</s> text formatting</li>
                                <li>Font, size, color changes</li>
                            </ul>
                        </li>
                        <li>Block formats:
                            <ul>
                                <li>Headings</li>
                                <li>Text alignment</li>
                                <li>Lists (bullet and numbered)</li>
                                <li>Code blocks</li>
                                <li>Quotes</li>
                            </ul>
                        </li>
                        <li>Variable support: produce documents based on templates</li>
                        <li>Toolbar with adaptive layout support</li>
                        <li>Insert images: specify a URL or upload from the local file system</li>
                        <li>Table support</li>
                    </ul>
                    <p>Supported browsers:
                    <table>
                        <tbody>
                            <tr>
                                <td><strong>Google Chrome (including Android)</strong></td>
                                <td>Latest</td>
                            </tr>
                            <tr>
                                <td><strong>Apple Safari (including iOS)</strong></td>
                                <td>Latest</td>
                            </tr>
                            <tr>
                                <td><strong>Mozilla Firefox</strong></td>
                                <td>Latest</td>
                            </tr>
                            <tr>
                                <td><strong>Microsoft Edge</strong></td>
                                <td>Latest</td>
                            </tr>
                            <tr>
                                <td><strong><a href='https://support.microsoft.com/en-us/microsoft-edge/what-is-microsoft-edge-legacy-3e779e55-4c55-08e6-ecc8-2333768c0fb0' rel='noopener noreferrer' target='_blank'>Microsoft Edge Legacy</a></strong></td>
                                <td>Not supported</td>
                            </tr>
                        </tbody>
                    </table>
                    <br>";
        }
    }
}
