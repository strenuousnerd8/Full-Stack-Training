const express = require('express')
const path = require('path')
const app = express()

const PORT = process.env.PORT || 3500

// Middleware function
const parseData = (req, res, next) => {
    if (req.method === 'POST') {
        const formData = {}
        req.on('data', data => {
            const parseData =
                decodeURIComponent(data).split('&')
            
            for (let data of parseData) {
                decodedData = decodeURIComponent(
                    data.replace(/\+/g, '%20')
                )

                const [key, value]
                    = decodedData.split('=')

                formData[key] = value
            }
            req.body = formData
            next()
        })
    } else {
        next()
    }
}

app.set("views", path.join(__dirname))
app.set("view engine", "ejs")

app.get('/', (req, res) => {
    res.render('template')
})

app.post('/information', parseData, (req, res) => {
    const data = req.body
    const {
        username,
        email,
        password,
        confirmPassword,
        sex,
    } = data

    console.log(data)
})

app.listen(PORT, () => {
    console.log(`Server start on port ${PORT}`)
})