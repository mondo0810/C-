import "./globals.css";
import { Inter } from "next/font/google";
import AuthProvider from "@/components/User/AuthProvider";

const inter = Inter({ subsets: ["latin"] });

export const metadata = {
  title: "Team Atom",
  description: "Team Atom",
};

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body className={inter.className}>
        <div className="">
          <AuthProvider>{children}</AuthProvider>
        </div>
      </body>
    </html>
  );
}
