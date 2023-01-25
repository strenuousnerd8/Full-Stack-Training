<script>
export default {
  data() {
    return {
      question: '',
      answer: 'Questions usually contain a question mark. ;-)'
    }
  },
  watch: {
    // whenever question changes, this function will run
    question(newQuestion) {
      if (newQuestion.indexOf('?') > -1) {
        this.getImage()
        this.getAnswer()
        
      }
    }
  },
  methods: {
    async getAnswer() {
      this.answer = 'Looking for ans'
      try {
        const res = await fetch('https://yesno.wtf/api')
        this.answer = (await res.json()).answer
        console.log(this.answer)
      } catch (error) {
        this.answer = 'Error! Could not reach the API. ' + error
      }
    },
    async getImage() {
      this.image = 'Here\'s your expression'
      try {
        const res = await fetch('https://yesno.wtf/api')
        this.image = (await res.json()).image
        console.log(this.image)
      } catch (error) {
        this.image = 'Error! Could not reach the API. ' + error
      }
    }
  }
}
</script>
 
<template>
<div id="app1">
<h1>
    Ask a yes/no question:
<input v-model="question" />
</h1>
<p style="font-size: 15px">{{ answer }}</p>
<img :src="image" alt="">
</div>
</template>
<style>
  * {
    font-family: 'consolas';
    text-align: center;
  }
  body, #app1, input {
    background: linear-gradient(to right, #c31432, #240b36);
    color: aliceblue;
  }
  input {
    border-radius: 10px;
    border: none;
    transition: border-radius 1s;
    width: 20vw;
    height: 5vh;
  }
  input:hover {
    border-radius: 3px;
  }
  li {
    text-align: left;
  }
  #app1 {
    color: black;
    margin-top: 25px;
    text-align: center;
    margin-left: 25%;
    margin-right: 25%;
    border-radius: 10px;
    background: linear-gradient(to right, #d3cce3, #e9e4f0);
    padding: 10px;
  }
  h1 {
    text-transform: lowercase;
  }
  h1:first-letter {
      text-transform: uppercase;
  }
  h1, h2, h3, h4, h6 {
    font-family: 'rage';
  }
  h5 {
    font-family: 'rage';
    font-size: large;
    
  }
  select, option {
    color: black
  }
  p {
    font-size: 10px;
  }
  #msel {
    overflow: hidden;
  }
  option {
    background: #414345;
  }
  input[type=checkbox] {
    width: 20px;
  }
  input[type="checkbox"]:checked {
    color: white;
  }
  button, select {
    border-radius: 10px;
    border: none;
  }
  img {
    border-radius: 10px;
  }
</style>