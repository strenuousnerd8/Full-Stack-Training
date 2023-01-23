<template>
    <div id="app">
        <button @click="count++">Count</button>
        COUNT IS {{ count }}
    </div>
</template>
<script>
export default {
    data() {
        return {
            count: 0
        }
    }
}
</script>
