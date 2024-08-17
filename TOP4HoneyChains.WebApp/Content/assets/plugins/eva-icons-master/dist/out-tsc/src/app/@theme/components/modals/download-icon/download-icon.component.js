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
exports.DownloadIconComponent = void 0;
var core_1 = require("@angular/core");
var url_service_1 = require("../../../../@core/data/service/url.service");
var theme_1 = require("@nebular/theme");
var analytics_service_1 = require("../../../services/analytics.service");
var DownloadIconComponent = /** @class */ (function () {
    function DownloadIconComponent(changeDetectorRef, urlService, dialogRef, analytics) {
        this.changeDetectorRef = changeDetectorRef;
        this.urlService = urlService;
        this.dialogRef = dialogRef;
        this.analytics = analytics;
        this.selectedIcon = '';
        this.iconType = '';
        this.downloadControls = [];
    }
    DownloadIconComponent.prototype.ngAfterViewInit = function () {
        this.downloadControls =
            this.urlService.getDownloadItemsDate(this.iconType, this.selectedIcon);
        this.changeDetectorRef.detectChanges();
    };
    DownloadIconComponent.prototype.closeDialog = function () {
        this.dialogRef.close();
    };
    DownloadIconComponent.prototype.clickOnDownloadIcon = function (icon) {
        this.analytics.trackEvent('downloadIcon', "".concat(this.selectedIcon, ".").concat(icon.format));
    };
    var _a, _b;
    __decorate([
        (0, core_1.Input)(),
        __metadata("design:type", String)
    ], DownloadIconComponent.prototype, "selectedIcon", void 0);
    __decorate([
        (0, core_1.Input)(),
        __metadata("design:type", String)
    ], DownloadIconComponent.prototype, "iconType", void 0);
    DownloadIconComponent = __decorate([
        (0, core_1.Component)({
            selector: 'eva-download-icon',
            styleUrls: ['./download-icon.component.scss'],
            templateUrl: './download-icon.component.html',
            changeDetection: core_1.ChangeDetectionStrategy.OnPush,
        }),
        __metadata("design:paramtypes", [typeof (_a = typeof core_1.ChangeDetectorRef !== "undefined" && core_1.ChangeDetectorRef) === "function" ? _a : Object, url_service_1.UrlService, typeof (_b = typeof theme_1.NbDialogRef !== "undefined" && theme_1.NbDialogRef) === "function" ? _b : Object, analytics_service_1.EvaAnalytics])
    ], DownloadIconComponent);
    return DownloadIconComponent;
}());
exports.DownloadIconComponent = DownloadIconComponent;
//# sourceMappingURL=download-icon.component.js.map