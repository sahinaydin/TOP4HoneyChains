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
exports.AnimationSwitcherComponent = void 0;
var core_1 = require("@angular/core");
var AnimationSwitcherComponent = /** @class */ (function () {
    function AnimationSwitcherComponent() {
        this.changeAnimation = new core_1.EventEmitter();
        this.animationItems = [
            {
                title: 'Zoom',
                iconName: 'maximize-outline',
                animationType: 'zoom',
            },
            {
                title: 'Pulse',
                iconName: 'activity-outline',
                animationType: 'pulse',
            },
            {
                title: 'Shake',
                iconName: 'shake-outline',
                animationType: 'shake',
            },
            {
                title: 'Flip in Y',
                iconName: 'flip-2-outline',
                animationType: 'flip',
            },
        ];
    }
    AnimationSwitcherComponent.prototype.ngOnInit = function () {
        this.selectedItem = this.animation;
    };
    AnimationSwitcherComponent.prototype.changeAnimationType = function (value) {
        this.changeAnimation.emit(value);
        this.animation = value;
    };
    var _a;
    __decorate([
        (0, core_1.Output)(),
        __metadata("design:type", typeof (_a = typeof core_1.EventEmitter !== "undefined" && core_1.EventEmitter) === "function" ? _a : Object)
    ], AnimationSwitcherComponent.prototype, "changeAnimation", void 0);
    __decorate([
        (0, core_1.Input)(),
        __metadata("design:type", String)
    ], AnimationSwitcherComponent.prototype, "animation", void 0);
    __decorate([
        (0, core_1.Input)(),
        __metadata("design:type", String)
    ], AnimationSwitcherComponent.prototype, "isMobileView", void 0);
    AnimationSwitcherComponent = __decorate([
        (0, core_1.Component)({
            selector: 'eva-animation-switcher',
            templateUrl: './animation-switcher.component.html',
            styleUrls: ['./animation-switcher.component.scss'],
        })
    ], AnimationSwitcherComponent);
    return AnimationSwitcherComponent;
}());
exports.AnimationSwitcherComponent = AnimationSwitcherComponent;
//# sourceMappingURL=animation-switcher.component.js.map