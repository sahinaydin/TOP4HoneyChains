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
var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.DataModule = void 0;
var core_1 = require("@angular/core");
var common_1 = require("@angular/common");
var icon_service_1 = require("./service/icons/icon.service");
var url_service_1 = require("./service/url.service");
var SERVICES = [
    icon_service_1.IconService,
    url_service_1.UrlService,
];
var DataModule = /** @class */ (function () {
    function DataModule() {
    }
    DataModule_1 = DataModule;
    DataModule.forRoot = function () {
        return {
            ngModule: DataModule_1,
            providers: __spreadArray([], SERVICES, true),
        };
    };
    var DataModule_1;
    DataModule = DataModule_1 = __decorate([
        (0, core_1.NgModule)({
            imports: [
                common_1.CommonModule,
            ],
            providers: __spreadArray([], SERVICES, true),
        })
    ], DataModule);
    return DataModule;
}());
exports.DataModule = DataModule;
//# sourceMappingURL=data.module.js.map