"use strict";
/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
Object.defineProperty(exports, "__esModule", { value: true });
exports.throwIfAlreadyLoaded = throwIfAlreadyLoaded;
function throwIfAlreadyLoaded(parentModule, moduleName) {
    if (parentModule) {
        throw new Error("".concat(moduleName, " has already been loaded. Import Core modules in the AppModule only."));
    }
}
//# sourceMappingURL=module-import-guard.js.map