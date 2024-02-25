import Navbar from "@/components/Navbar";
import Footer from "@/components/Footer";
import { AuthProvider } from "@/contexts/AuthContext";

export default async function HomeTemplate({ children }) {
  return (
    <main className="w-screen h-screen">
      <AuthProvider>
        <Navbar />
        {children}
        <Footer />
      </AuthProvider>
    </main>
  );
}
