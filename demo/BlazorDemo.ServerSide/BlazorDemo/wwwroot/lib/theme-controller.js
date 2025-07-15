"use strict";

export const ThemeController = (function () {
    async function switchBsThemeMode(bsThemeMode, reference) {
        document.querySelector("HTML").setAttribute("data-bs-theme", bsThemeMode);

        await reference.invokeMethodAsync("ThemeLoadedAsync");
    }

    return {
        switchBsThemeMode
    }
})();
