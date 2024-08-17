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
exports.TypeSwitcherComponent = void 0;
var core_1 = require("@angular/core");
var TypeSwitcherComponent = /** @class */ (function () {
    function TypeSwitcherComponent() {
        this.changeIconsType = new core_1.EventEmitter();
        this.navItems = [
            {
                title: 'Outline',
                type: 'outline',
                iconName: 'star-outline',
            },
            {
                title: 'Fill',
                type: 'fill',
                iconName: 'star',
            },
        ];
    }
    TypeSwitcherComponent.prototype.changeType = function (value) {
        this.changeIconsType.emit(value);
        this.iconsType = value;
    };
    var _a;
    __decorate([
        (0, core_1.Output)(),
        __metadata("design:type", typeof (_a = typeof core_1.EventEmitter !== "undefined" && core_1.EventEmitter) === "function" ? _a : Object)
    ], TypeSwitcherComponent.prototype, "changeIconsType", void 0);
    __decorate([
        (0, core_1.Input)(),
        __metadata("design:type", String)
    ], TypeSwitcherComponent.prototype, "iconsType", void 0);
    __decorate([
        (0, core_1.Input)(),
        __metadata("design:type", String)
    ], TypeSwitcherComponent.prototype, "isMobileView", void 0);
    TypeSwitcherComponent = __decorate([
        (0, core_1.Component)({
            selector: 'eva-type-switcher',
            templateUrl: './type-switcher.component.html',
            styleUrls: ['./type-switcher.component.scss'],
        })
    ], TypeSwitcherComponent);
    return TypeSwitcherComponent;
}());
exports.TypeSwitcherComponent = TypeSwitcherComponent;
//# sourceMappingURL=type-switcher.component.js.map