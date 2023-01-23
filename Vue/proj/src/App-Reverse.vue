<template>
  <div id="app">
      <h1>{{ message }}</h1>
      <button @click="reverseMsg">Reverse</button>
  </div>
</template>
<script>
export default {
  data() {
    return {
      message: "~|˘▾˘~|"
    }
  },
  methods: {
    reverseMsg() {
      this.message = this.message.split('').reverse().join('')
    }
  }
}
</script>