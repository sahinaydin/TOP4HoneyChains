"use strict";
/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
Object.defineProperty(exports, "__esModule", { value: true });
var protractor_1 = require("protractor");
describe('App common behavior', function () {
    beforeEach(function (done) {
        protractor_1.browser.get('').then(function () { return done(); });
    });
    it('should be active outline', function () {
        (0, protractor_1.element)(protractor_1.by.css('eva-type-switcher .nav-item.active span')).getText().then(function (value) {
            expect(value).toEqual('Outline');
        });
    });
    it('should contain list of icons', function () {
        protractor_1.element.all(protractor_1.by.css('eva-icon-list nb-card')).count()
            .then(function (count) {
            expect(count).toBeGreaterThan(10);
        });
    });
    it('should search "brush" icon', function () {
        (0, protractor_1.element)(protractor_1.by.css('.search-input')).sendKeys('brush')
            .then(function () {
            return protractor_1.browser.wait(function () {
                return protractor_1.element
                    .all(protractor_1.by.css('eva-icon-list nb-card:not(.fake-card)'))
                    .count()
                    .then(function (count) {
                    return count === 1;
                });
            }, 100);
        });
    });
    it('should open download icon popup', function () {
        (0, protractor_1.element)(protractor_1.by.css('eva-icon-list nb-card:nth-of-type(1)'))
            .click()
            .then(function () {
            var downloadIconPopup = (0, protractor_1.element)(protractor_1.by.css('eva-download-icon')).isDisplayed();
            expect(downloadIconPopup).toBeTruthy();
        });
    });
});
//# sourceMappingURL=app.e2e-spec.js.map