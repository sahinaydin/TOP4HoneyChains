"use strict";
/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.UrlService = void 0;
var core_1 = require("@angular/core");
var environment_1 = require("../../../../environments/environment");
var UrlService = /** @class */ (function () {
    function UrlService() {
        this.prefix_folder = 'package-build';
        this.DOWNLOAD_PROD_ZIP_URL = 'eva-icons.zip';
        this.DOWNLOAD_ZIP_URL = "".concat(this.prefix_folder, "/eva-icons.zip");
        this.DOWNLOAD_URLS = {
            svg: "".concat(this.prefix_folder, "/type/svg/name.svg"),
            png: "".concat(this.prefix_folder, "/type/png/128/name.png"),
        };
        this.DOWNLOAD_PROD_URLS = {
            svg: 'type/svg/name.svg',
            png: 'type/png/128/name.png',
        };
        this.downloadItemsData = [
            {
                format: 'svg',
                title: 'SVG',
                href: this.getDownloadItemUrl('svg'),
            },
            {
                format: 'png',
                title: 'PNG',
                href: this.getDownloadItemUrl('png'),
            },
        ];
    }
    UrlService.prototype.getDownloadItemUrl = function (format) {
        return environment_1.environment.production ?
            this.DOWNLOAD_PROD_URLS[format] :
            this.DOWNLOAD_URLS[format];
    };
    UrlService.prototype.getZippedIconsUrl = function () {
        return environment_1.environment.production ?
            this.DOWNLOAD_PROD_ZIP_URL :
            this.DOWNLOAD_ZIP_URL;
    };
    UrlService.prototype.getDownloadItemsDate = function (type, name) {
        var _this = this;
        var matches = {
            type: type,
            name: name,
        };
        return this.downloadItemsData.map(function (item) {
            return __assign(__assign({}, item), { href: _this.getIconHref(item.href, matches) });
        });
    };
    UrlService.prototype.getIconHref = function (href, matches) {
        return href.replace(/type|name/gi, function (matched) {
            return matches[matched];
        });
    };
    UrlService = __decorate([
        (0, core_1.Injectable)()
    ], UrlService);
    return UrlService;
}());
exports.UrlService = UrlService;
//# sourceMappingURL=url.service.js.map