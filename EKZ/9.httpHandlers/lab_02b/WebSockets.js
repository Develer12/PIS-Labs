var ta;
var ws = null;
window.onload = function () {
	if (Modernizr.websockets) {
		var span = document.getElementById('support');
		span.innerHTML = 'да';;
        ta = document.getElementById('ta');
    }
}

function exe_start() {
    if (ws == null) {
		ws = new WebSocket('ws://localhost:52225/websockets.websocket');
        ws.onopen = function () { ws.send('соединение'); }
        ws.onclose = function (s) { console.log('onclose', s); }
        ws.onmessage = function (evt) { ta.innerHTML += '\n' + evt.data; }
    }
}
