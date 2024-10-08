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
exports.DialogStateService = void 0;
var core_1 = require("@angular/core");
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var DialogStateService = /** @class */ (function () {
    function DialogStateService() {
        this.dialogState$ = new rxjs_1.ReplaySubject();
    }
    DialogStateService.prototype.changeDialogState = function (state) {
        this.dialogState$.next({ state: state });
    };
    DialogStateService.prototype.onChangeDialogState = function () {
        return this.dialogState$.pipe((0, operators_1.share)());
    };
    DialogStateService = __decorate([
        (0, core_1.Injectable)()
    ], DialogStateService);
    return DialogStateService;
}());
exports.DialogStateService = DialogStateService;
//# sourceMappingURL=dialog-state.service.js.map