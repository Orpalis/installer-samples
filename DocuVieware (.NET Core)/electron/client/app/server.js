const { app, BrowserWindow, Menu, ipcRenderer } = require('electron')
const path = require("path")
const { default: fetch } = require('electron-fetch');
require('dotenv').config()

var win = null;
function createWindow() {
  win = new BrowserWindow({
    width: 800,
    height: 600,
    webPreferences: {
      preload: path.join(__dirname, 'preload.js'),
      nodeIntegration: true,
      contextIsolation: false,
      webSecurity: false
    }
  });

  fetch(`${process.env.SERVER_SCHEME}://${process.env.SERVER_HOSTNAME}:${process.env.SERVER_PORT}/api/DocuVieware/GetDocuviewareLanguages`)
    .then(response => response.json())
    .then(result => {
      var languages = [];
      result.forEach(lang => {
        var infos = lang.split('|');
        var code = parseInt(infos[0]);
        var label = infos[1];
        languages.push({
          label: label,
          click: () => changeControlLang(code)
        })
      });
      let menu = Menu.buildFromTemplate([
        {
          label: 'Lang',
          submenu: languages
        },
        {
          label: "Edit document",
          submenu: [
            {
              label: "Add Signature form field",
              click: () => editDocument("AddSignatureFormField")
            }
          ]
        },
        {
          label: "Dev",
          submenu: [{
            label: "DevTool",
            role: 'toggleDevTools'
          },{
            label: "Reload",
            role: 'reload'
          }]
        }
      ]);
      Menu.setApplicationMenu(menu);
    }).catch(console.error)

  win.loadFile('app/index.html')
}

app.whenReady().then(createWindow)

function changeControlLang(code) {
  win.webContents.send('change-lang', code);
}

function editDocument(type) {
  win.webContents.send("edit-document", type)
}