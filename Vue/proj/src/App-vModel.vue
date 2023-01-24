<template>
  <div id="app1">
      <h1>{{ message }}</h1>
      <input v-model="message" />

      <h5>Checkbox</h5>
      <input type="checkbox" id="checkbox" v-model="checked">
      <label for="checked">checked: {{checked}}</label>

      <h5>Radio Button</h5>
      <input type="radio" id="one" value="one" v-model="picked">
      <label for="one">One</label>
      <br />
      <input type="radio" id="two" value="two" v-model="picked">
      <label for="two">Two</label>
      <br />
      <p>Picked : {{ picked }}</p>

      <h5>Select Example</h5>
      <select name="" id="" v-model="selected">
        <option value="" disabled>Please Select</option>
        <option value="A">A</option>
        <option value="B">B</option>
        <option value="C">C</option>
      </select>
      <p>Select : {{ selected }}</p>

      <h5>Multi-Select Example</h5>
      <select name="" id="msel" v-model="mselected" multiple>
        <option value="AA">AA</option>
        <option value="BB">BB</option>
        <option value="CC">CC</option>
      </select>
      <p>Selections : {{ mselected }}</p>

      <h5>Multicheck</h5>
      <input type="checkbox" value="1" id="checkbox1" v-model="mchecked">
      <label for="checkbox1">One</label>
      <input type="checkbox" value="2" id="checkbox2" v-model="mchecked">
      <label for="checkbox2">Two</label>
      <input type="checkbox" value="3" id="checkbox3" v-model="mchecked">
      <label for="checkbox3">Three</label>
      <input type="checkbox" value="4" id="checkbox4" v-model="mchecked">
      <label for="checkbox4">Four</label>
      <input type="checkbox" value="5" id="checkbox5" v-model="mchecked">
      <label for="checkbox5">Five</label>
      <p>checked: {{mchecked}}</p>

      <br />
      <button @click="fn">Greet</button>
      &nbsp;
      <button @click="say('hiii !')">Say Hi</button>
      &nbsp;
      <button @click="say('whatt ?')">Say What</button>
  </div>
</template>
<script>
export default {
    data() {
      return {
        message: "~(˘▾˘~)",
        checked: true,
        picked: "one",
        selected: 'A',
        mselected: ['AA'],
        mchecked: ['1'],
        name: "Team"
      }
    },
    methods: {
    fn(event) {
      alert(`Hello ${this.name}`)
      if(event) {
        alert(event.target.tagName)
      }
    },
    say(message) {
      alert(message)
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