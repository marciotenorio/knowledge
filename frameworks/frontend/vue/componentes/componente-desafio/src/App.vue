<template>
  <v-app>
    <MenuNavigation />
    <title-toolbar />
    <Carousel />
    <Footer />
  </v-app>
</template>

<script>
// @ é o caminho global a partir de src, @/ = src/
import MenuNavigation from './MenuNavigation.vue'
import TitleToolbar from './TitleToolbar.vue'
import Carousel from './Carousel.vue'
import Footer from './Footer.vue'

export default {
/** Posso nomear camelCase e mesmo assim escrever dash case que o vue vai entender,
 * ele entende que na proxima letra maiuscula deve deixar minuscula e por um - antes
  */
  components: {
    MenuNavigation,
    titleToolbar: TitleToolbar,
    Carousel,
    Footer: Footer
  },

}
</script>
