var DemoFeedbackHelper = (function() {
    var dotNetReference;
    function setDotNetReference(ref) {
        dotNetReference = ref;
    }

    var _feedbackServiceUrl = "https://js.devexpress.com/Feedback/Save/";
    function sendFeedbackData(requestParams) {
        var xhr = new XMLHttpRequest();
        xhr.open('POST', _feedbackServiceUrl, true);

        var form_data = new FormData();
        form_data.append("value", requestParams.value);
        form_data.append("document", window.location.pathname);
        form_data.append("project", "Blazor");
        form_data.append("host", window.location.host);
        form_data.append("title", document.title);
        form_data.append("versionName", requestParams.versionName);
        if(requestParams.message)
            form_data.append("message", requestParams.message);
        var doneCallback = function() {
            dotNetReference && dotNetReference.invokeMethodAsync('FeedbackCompleted');
        }
        var errorCallback = function() {
            dotNetReference && dotNetReference.invokeMethodAsync('FeedbackFailed');
        }
        xhr.onreadystatechange = function() {
            if(xhr.readyState == 4) {
                if(xhr.status == 200)
                    doneCallback();
                else
                    errorCallback();

            }
        }

        xhr.send(form_data);
    }
    function sendFeedback(value, message, versionName) {
        sendFeedbackData({ value: value, message: message, versionName: versionName });
    }

    return {
        setDotNetReference: setDotNetReference,
        sendFeedback: sendFeedback
    };
})();
