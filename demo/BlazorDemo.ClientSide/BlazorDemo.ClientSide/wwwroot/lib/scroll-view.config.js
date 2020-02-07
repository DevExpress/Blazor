"use strict";

/* Refer to https://js.devexpress.com/Documentation/Guide/Common/Modularity/Create_a_Custom_Bundle/ for information on how to create a DevExtreme bundle. */

/* Core (dx.module-core.js) */

var DevExpress = require("devextreme/bundles/modules/core");

/* UI core (dx.module-core.js) */

var ui = DevExpress.ui = require("devextreme/bundles/modules/ui");
ui.dxScrollView = require("devextreme/ui/scroll_view");