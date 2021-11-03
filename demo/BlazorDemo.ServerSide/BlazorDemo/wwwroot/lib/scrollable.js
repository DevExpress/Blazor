class DxDemoScrollable extends HTMLElement {
    _centerVertically = false;
    _centerHorizontally = false;
    connectedCallback() {
        const parent = this.parentElement;
        if (this._centerHorizontally)
            parent.scrollLeft = (this.offsetWidth - parent.offsetWidth) / 2;
        if (this._centerVertically)
            parent.scrollTop = (this.offsetHeight - parent.offsetHeight) / 2;
    }

    static get observedAttributes() {
        return ["center-horizontally", "center-vertically"];
    }
    attributeChangedCallback(name, oldValue, newValue) {
        switch (name) {
            case "center-horizontally":
                this._centerHorizontally = newValue === "";
                break;
            case "center-vertically":
                this._centerVertically = newValue === "";
                break;
        }
    }
}

customElements.define("dxbl-demo-scrollable", DxDemoScrollable);

function init(){

}
