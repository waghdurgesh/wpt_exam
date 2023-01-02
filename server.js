//initialization
const express = require('express');
const app = express();

//urls

app.get('/',(req,resp)=>{
    resp.sendFile('public/course_details.html',{root:__dirname});
})

app.get('/details',(req,resp)=>{
    resp.sendFile('public/course_schedule.html',{root:__dirname});
})


//server start
app.listen(6969);
console.log("Node server started at 6969 port !");