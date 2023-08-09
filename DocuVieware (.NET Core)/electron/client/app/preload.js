const ipcRenderer = require("electron").ipcRenderer;

window.addEventListener('DOMContentLoaded', () => {
  window.processId = `${process.pid}`;
  ipcRenderer.emit("preload-done");
});