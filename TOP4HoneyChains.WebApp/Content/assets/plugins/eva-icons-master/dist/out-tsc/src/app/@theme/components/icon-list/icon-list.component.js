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
exports.IconListComponent = void 0;
var core_1 = require("@angular/core");
var operators_1 = require("rxjs/operators");
var theme_1 = require("@nebular/theme");
var IconListComponent = /** @class */ (function () {
    function IconListComponent(scrollService) {
        var _this = this;
        this.scrollService = scrollService;
        this.alive = true;
        this.isMobileView = false;
        this.clickIcon = new core_1.EventEmitter();
        this.trackByFn = function (_, item) { return item.order; };
        this.scrollService.onScroll()
            .pipe((0, operators_1.takeWhile)(function () { return _this.alive && _this.isMobileView; }))
            .subscribe(function () {
            _this.popovers.forEach(function (popover) {
                popover.hide();
            });
        });
    }
    IconListComponent.prototype.clickIconHandler = function (icon) {
        this.clickIcon.emit(icon);
    };
    IconListComponent.prototype.ngOnDestroy = function () {
        this.alive = false;
    };
    var _a, _b;
    __decorate([
        (0, core_1.ViewChildren)(theme_1.NbPopoverDirective),
        __metadata("design:type", Array)
    ], IconListComponent.prototype, "popovers", void 0);
    __decorate([
        (0, core_1.Input)(),
        __metadata("design:type", Array)
    ], IconListComponent.prototype, "icons", void 0);
    __decorate([
        (0, core_1.Input)(),
        __metadata("design:type", Boolean)
    ], IconListComponent.prototype, "isMobileView", void 0);
    __decorate([
        (0, core_1.Input)(),
        __metadata("design:type", String)
    ], IconListComponent.prototype, "animationType", void 0);
    __decorate([
        (0, core_1.Output)(),
        __metadata("design:type", typeof (_b = typeof core_1.EventEmitter !== "undefined" && core_1.EventEmitter) === "function" ? _b : Object)
    ], IconListComponent.prototype, "clickIcon", void 0);
    IconListComponent = __decorate([
        (0, core_1.Component)({
            selector: 'eva-icon-list',
            templateUrl: './icon-list.component.html',
            styleUrls: ['./icon-list.component.scss'],
            changeDetection: core_1.ChangeDetectionStrategy.OnPush,
        }),
        __metadata("design:paramtypes", [typeof (_a = typeof theme_1.NbLayoutScrollService !== "undefined" && theme_1.NbLayoutScrollService) === "function" ? _a : Object])
    ], IconListComponent);
    return IconListComponent;
}());
exports.IconListComponent = IconListComponent;
//# sourceMappingURL=icon-list.component.js.map