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
        form_data.append("document", requestParams.document);
        form_data.append("project", requestParams.project);
        form_data.append("host", requestParams.host);
        if(requestParams.message)
            form_data.append("message", requestParams.message);
        var doneCallback = function() {
            if(requestParams.completed)
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
    function sendFeedback(value, message, completed) {
        sendFeedbackData({ value: value, document: window.location.pathname, project: "Blazor", host: window.location.host, message: message, completed: completed });
    }

    return {
        setDotNetReference: setDotNetReference,
        sendFeedback: sendFeedback
    };
})();
