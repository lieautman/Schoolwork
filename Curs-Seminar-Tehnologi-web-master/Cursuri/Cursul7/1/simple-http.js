const http = require('http')
const url = require('url')

const server = http.createServer()

//similar express
server.on('request',(req,res)=>{
    
    const parsed = url.parse(req.url)
    console.log(parsed)

    req.writeHead(200, {'Content-Type':'text/plain'})
    res.end('got it!')
})

server.listenerCount(8080)