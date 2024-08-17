"use strict";
/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.EvaVersionService = void 0;
var core_1 = require("@angular/core");
var EvaVersionService = /** @class */ (function () {
    function EvaVersionService() {
    }
    EvaVersionService.prototype.getEvoVersion = function () {
        return require('../../../../package.json').version;
    };
    EvaVersionService = __decorate([
        (0, core_1.Injectable)()
    ], EvaVersionService);
    return EvaVersionService;
}());
exports.EvaVersionService = EvaVersionService;
//# sourceMappingURL=version.service.js.map