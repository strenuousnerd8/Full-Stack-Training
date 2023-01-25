<script>
import Home from './components/HomeComp.vue'
import About from './components/AboutComp.vue'
import NotFound from './components/NotFound.vue'
 
const routes = {
  '/': Home,
  '/about': About
}
 
export default {
  data() {
    return {
      currentPath: window.location.hash
    }
  },
  computed: {
    currentView() {
      return routes[this.currentPath.slice(1) || '/'] || NotFound
    }
  },
  mounted() {
    window.addEventListener('hashchange', () => {
          this.currentPath = window.location.hash
        })
  }
}
</script>
 
<template>
<div id="app1">
<a href="#/">Home</a> |
<a href="#/about">About</a> |
<a href="#/non-existent-path">Broken Link</a>
<component :is="currentView" />
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