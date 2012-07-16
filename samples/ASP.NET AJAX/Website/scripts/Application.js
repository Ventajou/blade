
if(typeof Application == 'undefined') Application = {};

Application.Timer = (function() {
    Blade.derive(Timer, Sys.Component);
    var $base = Sys.Component.prototype;
    function Timer() {
        $base.constructor.call(this);
    }
    var p = Timer.prototype;
    p.add_timer = function (handler) {
        get_events().addHandler('timer', handler);
    }
    p.remove_timer = function (handler) {
        get_events().removeHandler('timer', handler);
    }
    p.initialize = function () {
        setInterval((function() {
            document.writeln(new Date().toString());
            var handler = get_events().getHandler('timer');
            if (handler !== null) {
                handler(this, Sys.EventArgs.Empty);
            }
        }), 1000);
        $base.initialize();
    }
    Blade.impl(Timer, 'Sys.INotifyPropertyChange', 'Sys.INotifyDisposing', 'Sys.IDisposable');
    return Timer;
})();
