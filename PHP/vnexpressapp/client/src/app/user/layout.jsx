import NavBarReponsive from "../../components/NavBarReponsive";
import Footer from "../../components/Footer";
export default function ProductsLayout({ children }) {
  return (
    <main>
      <NavBarReponsive />
      {children}
      <Footer />
    </main>
  );
}
