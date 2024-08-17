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
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.EvaAnalytics = void 0;
var core_1 = require("@angular/core");
var theme_1 = require("@nebular/theme");
var EvaAnalytics = /** @class */ (function () {
    function EvaAnalytics(window) {
        this.window = window;
        this.enabled = this.window.location.href.indexOf('akveo.github.io') >= 0;
    }
    EvaAnalytics.prototype.trackEvent = function (eventName, eventVal) {
        if (eventVal === void 0) { eventVal = ''; }
        if (this.enabled) {
            this.gtmPushToDataLayer({ event: eventName, eventValue: eventVal });
        }
    };
    // Push to 'dataLayer' Google Tag Manager array
    EvaAnalytics.prototype.gtmPushToDataLayer = function (params) {
        this.window.dataLayer.push(params);
    };
    EvaAnalytics = __decorate([
        (0, core_1.Injectable)(),
        __param(0, (0, core_1.Inject)(theme_1.NB_WINDOW)),
        __metadata("design:paramtypes", [Object])
    ], EvaAnalytics);
    return EvaAnalytics;
}());
exports.EvaAnalytics = EvaAnalytics;
//# sourceMappingURL=analytics.service.js.map