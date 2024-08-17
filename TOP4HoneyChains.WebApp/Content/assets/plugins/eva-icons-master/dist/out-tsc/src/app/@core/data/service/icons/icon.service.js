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
exports.IconService = exports.IconServiceData = void 0;
var rxjs_1 = require("rxjs");
var core_1 = require("@angular/core");
var eva_1 = require("../../../../../../package-build/eva");
var fill_icons_order_1 = require("./fill-icons-order");
var outline_icons_order_1 = require("./outline-icons-order");
var icons_tags_1 = require("./icons-tags");
var Icon = /** @class */ (function () {
    function Icon() {
    }
    return Icon;
}());
var Icons = /** @class */ (function () {
    function Icons() {
    }
    return Icons;
}());
var IconServiceData = /** @class */ (function () {
    function IconServiceData() {
    }
    return IconServiceData;
}());
exports.IconServiceData = IconServiceData;
var IconService = /** @class */ (function () {
    function IconService() {
        var _this = this;
        this.data = {
            icons: [],
            message: '',
        };
        this.sortIcons = function (first, second) { return first.order - second.order; };
        this.orders = {
            fill: fill_icons_order_1.fillOrder,
            outline: outline_icons_order_1.outlineOrder,
        };
        this.icons = Object.keys(eva_1.icons)
            .reduce(function (result, item, index, iconsArray) {
            var itemType = item.indexOf('outline') === -1 ? 'fill' : 'outline';
            var iconData = _this.getIconData(item, itemType);
            result[itemType] = result[itemType].concat(iconData);
            // sort items in last iteration
            if (index === iconsArray.length - 1) {
                result['outline'].sort(_this.sortIcons);
                result['fill'].sort(_this.sortIcons);
            }
            return result;
        }, { fill: [], outline: [] });
    }
    IconService.prototype.getIconData = function (icoName, iconType) {
        var groupTagName = icoName.replace('-outline', '');
        var tags = this.getIconsTags(groupTagName, icoName);
        return {
            name: icoName,
            order: this.orders[iconType][icoName],
            tags: tags,
        };
    };
    IconService.prototype.getIconsTags = function (groupName, icoName) {
        return icons_tags_1.iconsTags[groupName] && icons_tags_1.iconsTags[groupName].length > 0 ?
            icons_tags_1.iconsTags[groupName].concat(icoName) :
            [icoName];
    };
    IconService.prototype.getIconsData = function (type) {
        this.data.icons = this.icons[type];
        return (0, rxjs_1.of)(this.data);
    };
    IconService.prototype.getFilteredIconsData = function (searchKey, type) {
        var foundIcons = this.icons[type].filter(function (item) {
            return item.tags.some(function (tag) { return tag.indexOf(searchKey.toLowerCase()) !== -1; });
        });
        this.data.icons = foundIcons;
        this.data.message = foundIcons.length === 0 ? 'Oops… here are no results that match your search.' : '';
        return (0, rxjs_1.of)(this.data);
    };
    IconService = __decorate([
        (0, core_1.Injectable)(),
        __metadata("design:paramtypes", [])
    ], IconService);
    return IconService;
}());
exports.IconService = IconService;
//# sourceMappingURL=icon.service.js.map