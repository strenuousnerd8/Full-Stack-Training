<template>
  <div id="app1">
    <form @submit.prevent="updatePost">
      <button>Update Post</button>
    </form>
  </div>
</template>

<script>
export default {
  methods: {
    updatePost() {
      fetch('https://jsonplaceholder.typicode.com/posts/1',{
        method:  'PUT',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          userId: 1,
          id:     1,
          title:  'New post title',
          body:   'Lorem ipsum dolor sit amet'
        })
      })
        .then(response => response.json())
        .then(data => console.log(data))
    }
  }
}
</script>

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