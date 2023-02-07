<script> 
export default {
  data() {
    return {
      post: []
    }
  },
  methods: {
    async getPosts() {
      fetch('https://jsonplaceholder.typicode.com/posts/')
      .then(response => response.json())
      .then(data => this.post = data)
    }
  }
}
</script>
 
<template>
<div id="app1">
  <button @click="getPosts">
    Show Posts
  </button>
  <hr>

  <div v-for="p in post" :key="p.id">
    <h2>
      {{ p.id }} - {{ p.title }}
    </h2>
    <p>
      {{ p.body }}
    </p>

  </div>
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
</style>