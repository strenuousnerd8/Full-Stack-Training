<template>
  <div id="app1">
    <button @click="y = !y">Switch!</button>
    <h2 v-if="y">Y is true</h2>
    <h2 v-else>Y is false</h2>

    <hr>

    <h3 v-if='x === 0'>
      Number is 0
    </h3>
    <h3 v-else-if='x > 0'>
      Number is positive
    </h3>
    <h3 v-else-if='x < 0'>
      Number is negative
    </h3>
    <h3 v-else>
      Not a number
    </h3>

    <hr>

    <ul>
      <li v-for="item in z" :key="item">
        {{item}}
      </li>
    </ul>

    <ul>
      <li v-for="(z1, z2) in p" :key="z1">
        {{ z2 }} : {{ z1 }}
      </li>
    </ul>

  </div>
</template>
<script>
export default {
    data() {
      return {
        x: "",
        y: true,
        z: ['This', 'is', 'an', 'unordered', 'list'],
        p: [
          {
            a1: "AA",
            a2: "BB",
            a3: "CC"
          },
          {
            a1: "DD",
            a2: "EE",
            a3: "FF"
          }
        ]
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
</style>