<template>
  <div id="app1">
      <h1>{{ message }}</h1>
      <input type="number" :value="c" @change="setC"> Celcius &nbsp;
      
      <input type="number" :value="f" @change="setF"> Farenheit
  </div>
</template>
<script>
export default {
  data() {
    return {
      message: "~|˘▾˘~|",
      c: 0,
      f: 32
    }
  },
  methods: {
    setC(e, c = +e.target.value) {
      this.c = c
      this.f = c * (9 / 5) + 32
    },
    setF(e, f = +e.target.value) {
      this.f = f
      this.c = (f - 32) * (5 / 9)
    }
  }
}
</script>
<style>
* {
  background: linear-gradient(to right, #16222a, #3a6073);
  font-family: 'Segoe UI semilight', Tahoma, Geneva, Verdana, sans-serif;
  text-align: center;
  color: aliceblue;
}
input {
  border-radius: 10px;
  border-color: #3a6073;
}
#app1 {
  margin: 0;
  position: absolute;
  top: 35%;
  left: 50%;
  -ms-transform: translateY(-50%);
  transform: translateY(-50%);
  -ms-transform: translateX(-50%);
  transform: translateX(-50%);
  border-radius: 10px;
  padding: 10px;
}
</style>