const readline = require('readline')

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
})

function log(...args) {
  console.log(...args)
}

function prompt(message) {
  // Present readline in an async-await fashion.
  return new Promise((resolve, reject) => {
    try {
      rl.question(`${message} `, resolve)
    } catch (error) {
      reject(error)
    }
  })
}

function promptClose() {
  rl.close()
}

module.exports = { log, prompt, promptClose }
