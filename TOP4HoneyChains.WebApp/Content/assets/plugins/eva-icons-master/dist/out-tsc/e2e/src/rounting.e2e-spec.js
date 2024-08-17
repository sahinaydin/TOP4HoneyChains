"use strict";
/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
Object.defineProperty(exports, "__esModule", { value: true });
var protractor_1 = require("protractor");
describe('Routing', function () {
    it('should open outline page', function (done) {
        protractor_1.browser.get('#/?type=outline')
            .then(function () {
            (0, protractor_1.element)(protractor_1.by.css('eva-type-switcher .nav-item.active span'))
                .getText()
                .then(function (value) {
                expect(value).toEqual('Outline');
                done();
            });
        });
    });
    it('should open fill page', function (done) {
        protractor_1.browser.get('#/?type=fill')
            .then(function () {
            (0, protractor_1.element)(protractor_1.by.css('eva-type-switcher .nav-item.active span'))
                .getText()
                .then(function (value) {
                expect(value).toEqual('Fill');
                done();
            });
        });
    });
    it('should open fill page with github icon', function (done) {
        protractor_1.browser.get('#/?type=fill&searchKey=github')
            .then(function () {
            protractor_1.element
                .all(protractor_1.by.css('eva-icon-list nb-card:not(.fake-card)'))
                .count()
                .then(function (value) {
                expect(value).toEqual(1);
                done();
            });
        });
    });
});
//# sourceMappingURL=rounting.e2e-spec.js.map