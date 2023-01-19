var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var A = /** @class */ (function () {
    function A(name) {
        this.name = name;
    }
    A.prototype.display = function () {
        console.log("Inside display method");
    };
    return A;
}());
var B = /** @class */ (function (_super) {
    __extends(B, _super);
    function B(a1, a2) {
        var _this = _super.call(this, a2) || this;
        _this.x1 = a1;
        _this.aa = "AAAA";
        return _this;
    }
    B.prototype.fn = function () {
        console.log("Inside fn");
        return;
    };
    B.prototype.fn2 = function () {
        console.log("Inside fn2");
        return "aa";
    };
    return B;
}(A));
var C = /** @class */ (function (_super) {
    __extends(C, _super);
    function C(aa, ab) {
        return _super.call(this, aa) || this;
    }
    C.prototype.fn = function () {
        console.log("Inside C, fn");
    };
    C.prototype.fn2 = function () {
        console.log("Inside C, fn2");
        return "CC";
    };
    return C;
}(A));
var b = new B(200, "AA");
b.fn();
b.fn2();
