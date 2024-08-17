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
Object.defineProperty(exports, "__esModule", { value: true });
exports.HeaderComponent = void 0;
var core_1 = require("@angular/core");
var url_service_1 = require("../../../@core/data/service/url.service");
var analytics_service_1 = require("../../services/analytics.service");
var version_service_1 = require("../../services/version.service");
var HeaderComponent = /** @class */ (function () {
    function HeaderComponent(urlService, analytics, versionService) {
        this.urlService = urlService;
        this.analytics = analytics;
        this.versionService = versionService;
        this.zipUrl = this.urlService.getZippedIconsUrl();
    }
    HeaderComponent.prototype.clickOnDownloadPack = function () {
        var version = this.versionService.getEvoVersion();
        this.analytics.trackEvent('downloadPack', "download pack version: ".concat(version));
    };
    HeaderComponent = __decorate([
        (0, core_1.Component)({
            selector: 'eva-header',
            styleUrls: ['./header.component.scss'],
            templateUrl: './header.component.html',
        }),
        __metadata("design:paramtypes", [url_service_1.UrlService,
            analytics_service_1.EvaAnalytics,
            version_service_1.EvaVersionService])
    ], HeaderComponent);
    return HeaderComponent;
}());
exports.HeaderComponent = HeaderComponent;
//# sourceMappingURL=header.component.js.map